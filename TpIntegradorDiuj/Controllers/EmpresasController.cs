﻿using Microsoft.ApplicationInsights.Extensibility.Implementation;
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
    public class EmpresasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            return View();
        }
        public List<Empresa> DeserializarArchivoEmpresas()
        {
            var file = Request.Files[0];
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var buffer = new StreamReader(file.InputStream).ReadToEnd();
            List<Empresa> listaEmpresas =  serializer.Deserialize<List<Empresa>>(buffer);
            return listaEmpresas;

        }
        [HttpPost]
        public JsonResult ObtenerEmpresasYPeriodos()
        {
            if (Request.Files.Count>0)
            {               
                List<Empresa> empresas = this.DeserializarArchivoEmpresas();
                List<int> periodos = new List<int>();
                foreach (var balances in empresas.Select(x=>x.Balances))
                {
                    foreach (var item in balances)                    
                        periodos.Add(item.Periodo);                   
                }
                periodos = periodos.Distinct().ToList();
                return Json(new { Success = true, Empresas = empresas, Periodos = periodos });
            }
            return Json(new { Success = false, Mensaje = "Hubo un error" });
        }
        [HttpPost]
        public JsonResult ObtenerBalancesDeEmpresaPorPeriodo(int idEmpresa,int anio)
        {
            if (Request.Files.Count > 0)
            {                
                List<Empresa> empresas = this.DeserializarArchivoEmpresas();
                var empresa = empresas.FirstOrDefault(x => x.Id == idEmpresa);
                var balance = empresa.Balances.FirstOrDefault(x => x.Periodo == anio);
                if (balance != null)
                {
                    return Json(new { Success = true, Cuentas = balance.Cuentas.ToList() });
                }
                else
                {
                   return Json(new { Success = false, Mensaje="No hay cuentas para: "+empresa.Nombre + " en el periodo "+anio });

                }
            }
            return Json(new { Success = false, Mensaje = "Hubo un error" });
        }
        public CalcularValorByFormula()
        {
            String input = "your text to parse here";
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new MyGrammarLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            MyGrammarParser parser = new MyGrammarParser(tokens);
            parser.buildParseTrees = true;
            IParseTree tree = parser.StartRule();
        }
    }
}