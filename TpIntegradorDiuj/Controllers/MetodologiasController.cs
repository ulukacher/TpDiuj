﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TpIntegradorDiuj.Models;

namespace TpIntegradorDiuj.Controllers
{
    public class MetodologiasController : Controller
    {
        // GET: Metodologias
        TpIntegradorDbContext db = TpIntegradorDbContext.GetInstance();
        public ActionResult Index()
        {
            List<Metodologia> metodologias = db.Metodologias.ToList();
            return View(metodologias);
        }
        private void setViewBagCondiciones()
        {
            ViewBag.ListCondiciones = db.Condiciones.Select(x => new SelectListItem
            {
                Text = x.Descripcion,
                Value = x.Id.ToString()
            }).ToList();
        }
        public ActionResult Create()
        {
            setViewBagCondiciones();
            return View();
        }
      
        [HttpPost]
        public ActionResult Create(Metodologia model,List<int> IdsCondiciones)
        {
            try
            {
                int[] arrayIds = IdsCondiciones.ToArray();
                List<Condicion> condicionesAAgregar = db.Condiciones.Where(x => arrayIds.Contains(x.Id)).ToList();
                model.Condiciones.AddRange(condicionesAAgregar);
                db.Metodologias.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                setViewBagCondiciones();
                return View();
            }
        }
        
        public List<Metodologia> DeserializarArchivoMetodologias()
        {
            //TODO: Falta crear el archivo json de las metodologias
            string buf = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Archivos/") + "metodologias.json");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Metodologia> listMetodologias = serializer.Deserialize<List<Metodologia>>(buf);
            return listMetodologias;

        }
        public ActionResult ObtenerEmpresasDeseables(int idMetodologia)
        {
            Metodologia met = db.Metodologias.FirstOrDefault(x => x.Id == idMetodologia);
            IEnumerable<Empresa> empresas = db.Empresas;
            List<Empresa> deseables = met.ObtenerEmpresasDeseables(empresas);
            ViewBag.Empresa_Nombre = met.Nombre;
            return View(deseables);
        }
        public ActionResult EvaluarConvenienciaInversion(int empresaId,int metodologiaId)
        {
            EmpresasController empController = new EmpresasController();
            //Obtengo la empresa solicitada
            Empresa empresa = db.Empresas.FirstOrDefault(x=>x.Id == empresaId);
            //Obtengo la metodologia solicitada
            Metodologia metodologia = db.Metodologias.FirstOrDefault(x => x.Id == metodologiaId);
            //Ejecuto las condiciones de la metodología, para tal empresa, para ver si conviene invertir o no
            bool result = metodologia.EsDeseableInvertir(empresa);
            return Json(new { EsDeseable = result });
        }
    }
}