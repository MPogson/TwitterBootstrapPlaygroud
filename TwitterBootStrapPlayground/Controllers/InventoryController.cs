using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzWare.NBuilder;
using TwitterBootStrapPlayground.Models;

namespace TwitterBootStrapPlayground.Controllers
{
    public class InventoryController : Controller
    {
        //
        // GET: /Inventory/

        public ActionResult InventoryMain()
        {
            return View();
        }

        public JsonResult GetInventory()
        {
            var braclets = Builder<Braclet>
                .CreateListOfSize(50)
                .Build();

            var jsonResult = Json(new Braclet {Discontinued = false, ProductID = 100, ProductName = "Testing", UnitPrice = 100, UnitsInStock = 200}, JsonRequestBehavior.AllowGet);
            return jsonResult;
        }

    }
}
