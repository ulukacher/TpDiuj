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
        public ActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Create(Metodologia model)
        {
            //
            /* JavaScriptSerializer serializer = new JavaScriptSerializer();

             //Obtengo las metodologias del archivo JSON
             List<Metodologia> metodologias = DeserializarArchivoMetodologias();
             int maxId = metodologias.Select(x => x.Id).Max();
             model.Id = maxId + 1;
             metodologias.Add(model);
             string jsonData = JsonConvert.SerializeObject(metodologias);
             System.IO.File.WriteAllText(Server.MapPath("~/App_Data/Archivos/") + "metodologias.json", jsonData);*/
            try
            {
                db.Metodologias.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                List<Metodologia> metodologias = db.Metodologias.ToList();
                return View(metodologias);
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

        public ActionResult EvaluarConvenienciaInversion(int empresaId,int metodologiaId)
        {
            EmpresasController empController = new EmpresasController();
            //Obtengo la empresa solicitada
            Empresa empresa = empController.DeserializarArchivoEmpresas().FirstOrDefault(x=>x.Id == empresaId);
            //Obtengo la metodologia solicitada
            Metodologia metodologia = DeserializarArchivoMetodologias().FirstOrDefault(x => x.Id == metodologiaId);
            //Ejecuto las condiciones de la metodología, para tal empresa, para ver si conviene invertir o no
            bool result = metodologia.EsDeseableInvertir(empresa);
            return Json(new { EsDeseable = result });
        }
    }
}