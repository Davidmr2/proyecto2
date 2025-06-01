using Microsoft.AspNetCore.Mvc;

namespace proyecto2.Controllers
{
	public class NumeroController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}


namespace Proyecto2.Controllers
{
	public class NumeroController : Controller
	{
		// Muestra el formulario
		public ActionResult Verificar()
		{
			return View();
		}

		// Recibe el número y verifica si es primo
		[HttpPost]
		public ActionResult Verificar(int numero)
		{
			string mensaje = EsPrimo(numero)
				? $"El número {numero} es primo."
				: $"El número {numero} no es primo.";

			ViewBag.Resultado = mensaje;
			return View();
		}

		// Función para verificar si es primo
		private bool EsPrimo(int num)
		{
			if (num <= 1) return false;
			if (num == 2) return true;

			for (int i = 2; i <= System.Math.Sqrt(num); i++)
			{
				if (num % i == 0)
					return false;
			}
			return true;
		}
	}
}
