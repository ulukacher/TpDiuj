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
        TpIntegradorDbContext db = TpIntegradorDbContext.GetInstance();

        public ActionResult Index()
        {
            List<Balance> balances = db.Balances.ToList();
            return View(balances);
        }
        public ActionResult Create()
        {
            ViewBag.Empresas = db.Empresas.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = x.Id.ToString()
            }).ToList();
            return View();
        }
        public ActionResult Details(int id)
        {
            Balance bal = db.Balances.FirstOrDefault(x => x.Id == id);
            return View(bal);
        }
        [HttpPost]
        public ActionResult Create(Balance balanceModel)
        {
            try
            {
                db.Balances.Add(balanceModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                ViewBag.Empresas = db.Empresas.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.Id.ToString()
                }).ToList();
                return View();
            }

        }
    }
}