using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public ActionResult GetInventory()
        {

            var data = Builder<Braclet>
                .CreateListOfSize(100)
                .All()
                .Do(row => row.UnitPrice = 59.99m)
                .Build();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
