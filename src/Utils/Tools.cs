using System;
using System.Collections.Generic;

namespace atahualpa_ferresys.Utils
{
    public class Tools
    {
        public const string API_URL = "http://localhost:8000/api/";
        public static List<string> ListadoBusquedaProductos = new List<string>()
        {
            "POR NOMBRE","POR DESCRIPCIÓN","POR FECHA DE INGRESO","POR PRESENTACIÓN","POR ID"
        };
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
