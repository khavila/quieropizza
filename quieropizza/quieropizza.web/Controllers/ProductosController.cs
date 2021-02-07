using quieropizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 3 Quesos";

            ///
            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza Suprema";

            ///
            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Peperonni";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pizza Hawaiana";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = "Pizza La MetLovers";

            var ListadeProductos = new List<ProductoModel>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
            ListadeProductos.Add(producto4);
            ListadeProductos.Add(producto5);

            return View(ListadeProductos);
        }
    }
}