using Microsoft.AspNetCore.Mvc;


namespace Proyecto2.Controllers
{
	public class HomeController : Controller
	{
		// Muestra el formulario
		public ActionResult Formulario()
		{
			return View();
		}

		// Recibe el nombre y muestra el mensaje
		[HttpPost]
		public ActionResult Saludo(string nombre)
		{
			ViewBag.Mensaje = "Hola, " + nombre + ", bienvenido a ASP.NET MVC.";
			return View();
		}
	}
}
