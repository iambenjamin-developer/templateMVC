using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class Producto
    {

        public int ID { get; set; }

        public string DESCRIPCION { get; set; }

        public decimal PRECIO { get; set; }

        public int STOCK { get; set; }

        public DateTime? FECHA_VENCIMIENTO { get; set; }

        public bool ACTIVO { get; set; }


    }
}