using Ejercicio1.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Ejercicio1.Api
{
    public class Methodo
    {
        private static string ulrApi;
        private static string host = "https://api.exchangeratesapi.io/";
        private static HttpClient client = new HttpClient();
        private static string parapais;
        public Methodo(string de,string para) {
            ulrApi = $"{host}latest?base={de}&symbols={para}";
            parapais = para;
        }

        public string  ResultadoMoneda ()
        {

            try
            {
                object Dep = null;
                var result1 = Get();
                if (result1.IsSuccessStatusCode)
                {
                    Dep = result1.Content.ReadAsAsync<object>().Result;
                }
                JObject o = JObject.Parse(Dep.ToString());
                string name = (string)o["rates"][$"{parapais}"];
                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error traer departamentos.. {ex.StackTrace} ");
                return null;
            }

        }

        private HttpResponseMessage Get()
        {
            return client.GetAsync(ulrApi).Result;

        }
    }
}