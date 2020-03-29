
using System.Collections.Generic;
namespace Ejercicio1.Models.ListaPaises
{
    public class ListaPs
    {
        private List<Pais> paises;
        public ListaPs() {
            paises = new List<Pais> {
                new Pais {
                Codigo="AUD",
                Nombre="AUSTRALIA"
            },
                new Pais {
                Codigo="BGN",
                Nombre="BULGARIA"
            },
                new Pais {
                Codigo="BRL",
                Nombre="BRASIL"
            },
                new Pais {
                Codigo="CAD",
                Nombre="CANADA"
            },
               new Pais {
                Codigo="CHF",
                Nombre="SUIZA"
            },
                 new Pais {
                Codigo="CNY",
                Nombre="CHINA"
            },
                 new Pais {
                Codigo="CZK",
                Nombre="REPUBLICA CHECA"
            },
                      new Pais {
                Codigo="DKK",
                Nombre="DINAMARCA"
            },
                           new Pais {
                Codigo="EUR",
                Nombre="EUROPA"
            },
                     new Pais {
                Codigo="GBP",
                Nombre="REINO UNIDO"
            },
                 new Pais {
                Codigo="HKD",
                Nombre="HONG KONG"
            },
                 new Pais {
                Codigo="HUF",
                Nombre="HUGRANIA"
            },
                      new Pais {
                Codigo="IDR",
                Nombre="INDONESIA"
            },
                new Pais {
                Codigo="ILS",
                Nombre="ISRAEL"
            },
              new Pais {
                Codigo="INR",
                Nombre="INDIA"
            },
                  new Pais {
                Codigo="JPY",
                Nombre="JAPON"
            },
                new Pais {
                Codigo="KRW",
                Nombre="COREA DEL SUR"
            },
                new Pais {
                Codigo="MXN",
                Nombre="MEXICO"
            },
                   new Pais {
                Codigo="MYR",
                Nombre="MALASIA"
            },
                      new Pais {
                Codigo="NOK",
                Nombre="NORUEGA"
            },
                         new Pais {
                Codigo="NZD",
                Nombre="NUEVA ZELANDA"
            },
                            new Pais {
                Codigo="PHP",
                Nombre="PHILIPINE"
            },
                               new Pais {
                Codigo="PLN",
                Nombre="POLONIA"
            },
              new Pais {
                Codigo="RON",
                Nombre="ROMANIA"
            },
              new Pais {
                Codigo="RUB",
                Nombre="RUSIA"
            },
              new Pais {
                Codigo="SEK",
                Nombre="SUECIA"
            },
                new Pais {
                Codigo="SGD",
                Nombre="SINGAPORE"
            },
               new Pais {
                Codigo="THB",
                Nombre="TAILANDIA"
            },
                 new Pais {
                Codigo="TRY",
                Nombre="TURKIA"
            },
                   new Pais {
                Codigo="USD",
                Nombre="EE-UU"
            },
                     new Pais {
                Codigo="ZAR",
                Nombre="SOUTH AFRICAN"
            },
                new Pais {
                Codigo="USD",
                Nombre="ECUADOR"
            },
            };   
        }

        public List<Pais> ListaPaises() {
            return paises;
        }

    }
}