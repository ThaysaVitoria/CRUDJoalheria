using CrudJoalheria.Data;
using CrudJoalheria.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
	public class VendedorController : Controller
	{
		readonly private ApplicationDBContext _db;

		public VendedorController(ApplicationDBContext db)
		{
			_db = db;
		}


		public IActionResult Index()
		{
			IEnumerable<VendedorModel> Vendedor = _db.Vendedor;
			return View(Vendedor);
		}
		public IActionResult Cadastrar()
		{
			return View();
		}
	}
}