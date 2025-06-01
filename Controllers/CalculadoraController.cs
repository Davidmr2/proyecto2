using Microsoft.AspNetCore.Mvc;

namespace proyecto2.Controllers
{
	public class CalculadoraController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}


namespace Proyecto2.Controllers
{
	public class CalculadoraController : Controller
	{
		// Muestra el formulario
		public ActionResult Calcular()
		{
			return View();
		}

		// Recibe los valores y operación, y calcula
		[HttpPost]
		public ActionResult Calcular(double valor1, double valor2, string operacion)
		{
			double resultado = 0;
			string mensaje = "";

			switch (operacion)
			{
				case "+":
					resultado = valor1 + valor2;
					break;
				case "-":
					resultado = valor1 - valor2;
					break;
				case "*":
					resultado = valor1 * valor2;
					break;
				case "/":
					if (valor2 != 0)
						resultado = valor1 / valor2;
					else
						mensaje = "No se puede dividir entre 0.";
					break;
				default:
					mensaje = "Operación no válida.";
					break;
			}

			if (mensaje == "")
				mensaje = $"El resultado es: {resultado}";

			ViewBag.Resultado = mensaje;

			return View();
		}
	}
}
