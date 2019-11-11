using System;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IJurosService
    {
        ResponseModel CalcularJuros(double valorInicial, int meses);
    }
}
