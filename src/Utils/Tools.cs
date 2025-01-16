using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms.VisualStyles;

namespace atahualpa_ferresys.Utils
{
    public class Tools
    {
        public const string API_URL = "http://localhost:8000/api/";
        public const string JWT_TOKEN = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjgwMDAvYXBpL2F1dGgvbG9naW4iLCJpYXQiOjE3MzY3OTM4NzksImV4cCI6MTczNzM5ODY3OSwibmJmIjoxNzM2NzkzODc5LCJqdGkiOiJxM1VVWVFrb1R5OGk5Yng0Iiwic3ViIjoiMiIsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjciLCJ1c2VybmFtZSI6IlZFTkRFRE9SIiwiZW1haWwiOiJjYXJsaXRvc0BnbWFpbC5lcyIsInJvbGVfaWQiOjJ9.s-fcJiopv3LRcyI-mvlOV6qxSuTpyWZxZWwm4lnBWFY";
        public static List<string> ListadoBusquedaProductos = new List<string>()
        {
            "POR NOMBRE","POR DESCRIPCIÓN","POR FECHA DE INGRESO","POR PRESENTACIÓN","POR ID"
        };

        public static List<string> ProductSearchCriteria = new List<string>()
        {
            "POR NOMBRE","POR DESCRIPCIÓN","POR ID","POR PRESENTACIÓN","POR FECHA DE INGRESO"
        };

        public static double TryParseDouble(string str)
        {
            if (Double.TryParse(str, out double result))
            {
                return Math.Round(result, 2);
            }
            else
            {
                return 0.00;
            }
        }

        public static int TryParseInt(string str)
        {
            return Int32.TryParse(str, out int result) ? result : 0;
        }
    }

    public class FrontProducto
    {
        public int ID_PROD { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO_COMP { get; set; }
        public decimal PRECIO_VENT { get; set; }
        public int STOCK { get; set; }
        public DateTime? FECHA_INGRESO { get; set; }
        public string TIPO_UNIDAD { get; set; }
        public string PROVEEDOR { get; set; }
        public bool ACTIVO { get; set; }
    }
}
