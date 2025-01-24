using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace atahualpa_ferresys.Utils
{
    public class Tools
    {
        public const string API_URL = "http://localhost:8000/api/";
        public const string JWT_TOKEN = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjgwMDAvYXBpL2F1dGgvbG9naW4iLCJpYXQiOjE3MzczOTk5MzgsImV4cCI6MTczODAwNDczOCwibmJmIjoxNzM3Mzk5OTM4LCJqdGkiOiIwMHJyU1RKMTY2d2lDZTdtIiwic3ViIjoiMiIsInBydiI6IjIzYmQ1Yzg5NDlmNjAwYWRiMzllNzAxYzQwMDg3MmRiN2E1OTc2ZjciLCJ1c2VybmFtZSI6IlZFTkRFRE9SIiwiZW1haWwiOiJjYXJsaXRvc0BnbWFpbC5lcyIsInJvbGVfaWQiOjJ9.1euwmt9JVWeZgUNKb10Upa1nmFdVtVG-NUpjvV8vnFc";
        public static List<string> ListadoBusquedaProductos = new List<string>()
        {
            "POR NOMBRE","POR DESCRIPCIÓN","POR FECHA DE INGRESO","POR PRESENTACIÓN","POR ID"
        };

        public static List<string> ProductSearchCriteria = new List<string>()
        {
            "POR NOMBRE","POR DESCRIPCIÓN","POR ID","POR PRESENTACIÓN","POR FECHA DE INGRESO"
        };

        public static List<string> SupplierSearchCriteria = new List<string>()
        {
            "POR ID","POR RUC","POR NOMBRE","POR EMAIL"
        };

        public static List<string> CustomerSearchCriteria = new List<string>()
        {
            "POR DNI","POR ID"
        };

        public static List<string> SellFormSearchCriteria = new List<string>()
        {
            "POR ID","POR NOMBRE"
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

        public static bool IsNumeric(string input)
        {
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^\d+$");
        }

        public static void EnableDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public class ProductHelper
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public string UnitTypeName { get; set; }
            public int BuyAmount { get; set; }
            public double Subtotal { get; set; }

            public ProductHelper() { }
            public ProductHelper(int id, string name, double price, int stock, string unitTypeName, int buyAmount)
            {
                Id = id;
                Name = name;
                Price = price;
                Stock = stock;
                UnitTypeName = unitTypeName;
                BuyAmount = buyAmount;
            }
        }
    }



}
