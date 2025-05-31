using Microsoft.AspNetCore.Mvc;

namespace Proyecto2unidad1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}


public class HomeController : Controller
{
	public ActionResult Index()
	{
		return View();
	}

	[HttpPost]
	public ActionResult Saludo(string nombre)
	{
		ViewBag.Mensaje = "Hola " + nombre;
		return View("Index");
	}
}
