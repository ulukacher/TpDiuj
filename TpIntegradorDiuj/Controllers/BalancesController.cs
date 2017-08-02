﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TpIntegradorDiuj.Models;

namespace TpIntegradorDiuj.Controllers
{
    public class BalancesController : Controller
    {
        // GET: Cuentas
        EmpresasController empController = new EmpresasController();

        public ActionResult Index()
        {
            List<Balance> balances = new List<Balance>();
            foreach (var empresa in empController.DeserializarArchivoEmpresas())
            {
                balances.AddRange(empresa.Balances);
            }         
            return View(balances);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(Balance balanceModel)
        {
            List<Empresa> empresas = empController.DeserializarArchivoEmpresas();
            List<Balance> todosLosBalances = new List<Balance>();
            //Obtengo el ultimo ID de balance de todo el JSON
            foreach (var item in empresas)
            {
                //Agrego los balances de cada empresa a la lista de TODOS los balances
                todosLosBalances.AddRange(item.Balances);
            }
            Empresa empresa =empresas.FirstOrDefault(x => x.Id == balanceModel.Empresa_Id);
            int maxId = todosLosBalances.Max(x => x.Id);
            balanceModel.Id = maxId + 1;
            //Guardo el balance en el JSON
            empresa.Balances.Add(balanceModel);
            string jsonData = JsonConvert.SerializeObject(empresas);
            System.IO.File.WriteAllText(Server.MapPath("~/App_Data/Archivos/") + "empresas.json", jsonData);
            return RedirectToAction("Index");
        }
    }
}