using MvcProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Pratik Tarifler",
                CategoryCount = 1
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Çorbalar",
                CategoryCount = 2
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Etli Yemekler",
                CategoryCount = 3
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Dolmalar",
                CategoryCount = 4
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Zeytinyağlılar",
                CategoryCount = 5
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Hamur İşleri",
                CategoryCount = 6
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Ekmekler",
                CategoryCount = 7
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Börekler",
                CategoryCount = 8
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Pilavlar",
                CategoryCount = 9
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Makarnalar",
                CategoryCount = 10
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Tatlılar",
                CategoryCount = 11
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Pastalar",
                CategoryCount = 12
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kekler-Muffinler",
                CategoryCount = 13
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kurabiyeler-Bisküviler",
                CategoryCount = 14
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Diyet Tarifler",
                CategoryCount = 15
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "PÜnlü Diyetler",
                CategoryCount = 16
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kahvaltılıklar",
                CategoryCount = 17
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Reçeller",
                CategoryCount = 18
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "Turşular",
                CategoryCount = 19
            }); 
            ct.Add(new CategoryClass()
            {
                CategoryName = "İçecekler",
                CategoryCount = 20
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Salatalar",
                CategoryCount = 21
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Mezeler",
                CategoryCount = 22
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yöresel Yemekler",
                CategoryCount = 23
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Dünya Mutfakları",
                CategoryCount = 24
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kış Hazırlıkları",
                CategoryCount = 25
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Sokak Lezzetleri",
                CategoryCount = 26
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Tavuk Yemekleri",
                CategoryCount = 27
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Balıklar",
                CategoryCount = 28
            });
            return ct;
        }
    }
}