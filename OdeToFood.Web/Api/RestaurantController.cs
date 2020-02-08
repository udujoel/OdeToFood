using System.Web.Mvc;

using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantData _db;

        public RestaurantController(IRestaurantData db)
        {
            _db = db;
        }
        // GET: Restaurant
        public ActionResult Index()
        {

            var model = _db.GetAll();
            ; return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _db.Get(id);
            return View(model);
        }
    }
}