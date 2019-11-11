using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models;

namespace WebApi.Services
{
    public class JurosService : IJurosService
    {
        public ResponseModel CalcularJuros(double valorInicial, int meses)
        {
            double juros_mes = 0.01;

            if (valorInicial <= 0)
            {
                return ResponseModel.Factory.Create(false, "", "ValorInicial deve ser maior que zero.");
            }

            if (meses <= 0)
            {
                return ResponseModel.Factory.Create(false, "", "Meses deve ser maior que zero.");
            }

           

            double resultado = valorInicial * Math.Pow((1 + juros_mes), meses);
            resultado = Math.Truncate(100 * resultado) / 100;        

            return ResponseModel.Factory.Create(true, resultado.ToString("F"), "");
        }

    }
}
