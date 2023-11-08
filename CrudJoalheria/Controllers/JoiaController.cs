using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
	public class JoiaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
