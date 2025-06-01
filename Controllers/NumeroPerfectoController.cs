using Microsoft.AspNetCore.Mvc;

namespace proyecto2.Controllers
{
	public class NumeroPerfectoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}


namespace Proyecto2.Controllers
{
	public class NumeroPerfectoController : Controller
	{
		// Muestra el formulario
		public ActionResult Verificar()
		{
			return View();
		}

		// Verifica si el número es perfecto
		[HttpPost]
		public ActionResult Verificar(int numero)
		{
			string mensaje = EsPerfecto(numero)
				? $"El número {numero} es perfecto."
				: $"El número {numero} no es perfecto.";

			ViewBag.Resultado = mensaje;
			return View();
		}

		// Función que verifica si un número es perfecto
		private bool EsPerfecto(int num)
		{
			if (num <= 0) return false;

			int suma = 0;
			for (int i = 1; i < num; i++)
			{
				if (num % i == 0)
					suma += i;
			}
			return suma == num;
		}
	}
}
