using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facturacion.Controllers
{
    public class FacturaController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Listar(string name, string sidx, string sord, int page, int rows)
        {
            //int pageIndex = Convert.ToInt32(page) - 1;
            //int pageSize = rows;
            //int totalRecords = context.Count();
            //int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);


            var jsonData = new
            {
                total = 3,
                page = page,
                records = 3,
                //rows = new[]{    
                //            new {i= 1, cell= new string[] { "23450", "PUBLICIDAD", "12/03/2015", "SOLES", "12,345.00" } },
                //            new {i= 2, cell= new string[] { "23450", "PUBLICIDAD", "12/03/2015", "DÓLARES", "12,345.00" } },
                //            new {i= 3, cell= new string[] { "23450", "PUBLICIDAD", "12/03/2015", "SOLES", "12,345.00" } }
                //            }
            };

            // Return the result in json
            return Json(jsonData, JsonRequestBehavior.AllowGet);            
        }

    }
}
