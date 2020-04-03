using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class Metodos
    {
        public static List<Producto> ListarProductos()
        {

            List<Producto> lista = new List<Producto>
            {

                new Producto{ ID = 1, DESCRIPCION="Leche", PRECIO=70.68M, STOCK=200, FECHA_VENCIMIENTO = new DateTime(2020,05,25),ACTIVO= true},

                new Producto{ ID = 2, DESCRIPCION="Pala", PRECIO=13730.45M, STOCK=15, FECHA_VENCIMIENTO = null,ACTIVO= true},

                new Producto{ ID = 3, DESCRIPCION="Yerba", PRECIO=150.22M, STOCK=153, FECHA_VENCIMIENTO = new DateTime(2019,12,31),ACTIVO= false},

                new Producto{ ID = 15, DESCRIPCION="Jabon Tocador", PRECIO=40.88M, STOCK=349, FECHA_VENCIMIENTO = null,ACTIVO= false},

                new Producto{ ID = 65, DESCRIPCION="Caldo de Verduras", PRECIO=30.45M, STOCK=546, FECHA_VENCIMIENTO = new DateTime(2020,08,13),ACTIVO= true},

                new Producto{ ID = 23, DESCRIPCION="Fideos", PRECIO=60.55M, STOCK=333, FECHA_VENCIMIENTO = new DateTime(2021,10,30),ACTIVO= true},

                new Producto{ ID = 33, DESCRIPCION="Arroz", PRECIO=72.47M, STOCK=265, FECHA_VENCIMIENTO = new DateTime(2018,02,02),ACTIVO= false},

                new Producto{ ID = 17, DESCRIPCION="Nestum", PRECIO=150.99M, STOCK=58, FECHA_VENCIMIENTO = new DateTime(2020,05,28),ACTIVO= false},

                new Producto{ ID = 55, DESCRIPCION="Coca Cola", PRECIO=120.86M, STOCK=367, FECHA_VENCIMIENTO = null,ACTIVO= true},

                new Producto{ ID = 41, DESCRIPCION="Jugo Tang", PRECIO=20.66M, STOCK=567, FECHA_VENCIMIENTO = new DateTime(1935,05,25),ACTIVO= true},




                new Producto{ ID = 1, DESCRIPCION="Leche", PRECIO=23.456M, STOCK=200, FECHA_VENCIMIENTO = new DateTime(2020,05,25),ACTIVO= true},

                new Producto{ ID = 2, DESCRIPCION="Pala", PRECIO=234.342M, STOCK=15, FECHA_VENCIMIENTO = null,ACTIVO= true},

                new Producto{ ID = 3, DESCRIPCION="Yerba", PRECIO=234.009M, STOCK=153, FECHA_VENCIMIENTO = new DateTime(2019,12,31),ACTIVO= false},

                new Producto{ ID = 15, DESCRIPCION="Jabon Tocador", PRECIO=453.345M, STOCK=349, FECHA_VENCIMIENTO = null,ACTIVO= false},

                new Producto{ ID = 65, DESCRIPCION="Caldo de Verduras", PRECIO=875.43M, STOCK=546, FECHA_VENCIMIENTO = new DateTime(2020,08,13),ACTIVO= true},

                new Producto{ ID = 23, DESCRIPCION="Fideos", PRECIO=60.001M, STOCK=234, FECHA_VENCIMIENTO = new DateTime(2021,10,30),ACTIVO= true},

                new Producto{ ID = 33, DESCRIPCION="Arroz", PRECIO=2345234.23456M, STOCK=265, FECHA_VENCIMIENTO = new DateTime(2018,02,02),ACTIVO= false}

               

            };

            return lista;

        }

    }
}