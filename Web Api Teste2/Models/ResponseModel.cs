using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ResponseModel
    {

        public bool Sucesso { get; set; }


        public string Juros { get; set; }

        public string Mensagem { get; set; }



        #region Factory

        public static class Factory
        {
            public static ResponseModel Create(bool sucesso, string Juros, string msg)
                => new ResponseModel()
                {
                    Sucesso = sucesso,
                    Juros = Juros,
                    Mensagem = msg
                };
        }

        #endregion
    }
}
