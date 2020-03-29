using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio1.Models
{
    public class Respuesta
    {
        public class Rates
        {
            public double BRL { get; set; }
        }

        public class RootObject
        {
            public Rates rates { get; set; }
            public string @base { get; set; }
            public string date { get; set; }
        }
    }
}