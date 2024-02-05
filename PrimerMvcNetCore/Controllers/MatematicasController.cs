using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = "La suma de " + numero1
                + " + " + numero2 + "=" + suma;
            return View();
        }

        [HttpGet]
        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = "La suma de " + numero1
                + " + " + numero2 + "=" + suma;
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            //DECLARAMOS UN MODEL PARA ENVIAR A LA VISTA
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //DEVOLVEMOS EL MODEL A LA VISTA
            return View(numeros);
        }
    }
}
