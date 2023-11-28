using CrudJoalheria.Data;
using CrudJoalheria.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
	public class JoiaController : Controller
	{
		readonly private ApplicationDBContext _db;

		public JoiaController(ApplicationDBContext db)
		{
			_db = db;
		}


		public IActionResult Index()
		{
			IEnumerable<JoiaModel> Joia = _db.Joia;
			return View(Joia);
		}
		public IActionResult Cadastrar()
		{
			return View();
		}
		[HttpPost]

		public IActionResult Cadastrar(JoiaModel joiaModel) {
			if (ModelState.IsValid)
			{
				_db.Joia.Add(joiaModel);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}
			return View();
		}
	}
}