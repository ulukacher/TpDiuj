﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpIntegradorDiuj.Models
{
    public class Cuenta : ComponenteOperando
    {

        public int Id { get; set; }
        public int Balance_Id { get; set; }
        public double Valor { get; set; }

        //TODO: Pensar en que consiste este metodo
        public override double ObtenerValor(Empresa empresa, int periodo)
        {
            throw new NotImplementedException();
        }
    }
}