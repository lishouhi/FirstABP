using System.Web.Mvc;
using FirstABP.People;

namespace FirstABP.Web.Controllers
{
    public class HomeController : FirstABPControllerBase
    {
        private readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {
            //获取列表
            var p = _personService.GetPersons();
            return View();
        }
	}
}