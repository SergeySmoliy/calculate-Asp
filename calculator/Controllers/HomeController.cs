using System.Web.Mvc;
namespace calculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Viewcalcul()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Viewcalcul(int a, int b, string param)
        {
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Param = param;

            if (param == "+")
            {
                int res = a + b;
                ViewBag.Sum = res;
            }
            else if (param == "-")
            {
                int res = a - b;
                ViewBag.Sum = res;
            }
            else if (param == "*")
            {
                int res = a * b;
                ViewBag.Sum = res;
            }
            else if (param == "/")
            {
                int res = a / b;
                ViewBag.Sum = res;

            }
            return View();





        }


    }
}