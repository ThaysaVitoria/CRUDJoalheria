using CrudJoalheria.Data;
using CrudJoalheria.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
	public class ClienteController : Controller
	{
		readonly private ApplicationDBContext _db;

		public ClienteController(ApplicationDBContext db)
		{
			_db = db;
		}


		public IActionResult Index()
		{
			IEnumerable<ClienteModel> Cliente = _db.Cliente;
			return View(Cliente);
		}
		public IActionResult Cadastrar()
		{
			return View();
		}
	}
}