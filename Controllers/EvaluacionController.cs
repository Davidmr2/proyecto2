using Microsoft.AspNetCore.Mvc;

namespace proyecto2.Controllers
{
	public class EvaluacionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}


namespace Proyecto2.Controllers
{
	public class EvaluacionController : Controller
	{
		// Muestra el formulario
		public ActionResult Calificar()
		{
			return View();
		}

		// Recibe las calificaciones y evalúa
		[HttpPost]
		public ActionResult Calificar(double nota1, double nota2, double nota3, double nota4)
		{
			double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
			string resultado;

			if (promedio >= 70)
				resultado = $"Aprobado con promedio de {promedio}.";
			else if (promedio >= 60)
				resultado = $"En recuperación con promedio de {promedio}.";
			else
				resultado = $"Reprobado con promedio de {promedio}.";

			ViewBag.Mensaje = resultado;
			return View();
		}
	}
}
