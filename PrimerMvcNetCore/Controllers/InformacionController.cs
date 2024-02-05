using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //SIEMPRE DEBEMOS TENER UN METODO GET
        public IActionResult VistaControladorPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControladorPost
            (Persona persona, string aficiones)
        {
            ViewData["DATOS"] = "Nombre: " + persona.Nombre
                + ", Email: " + persona.Email
                + ", Edad: " + persona.Edad
                + ", Aficiones: " + aficiones;
            return View();
        }


        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            ViewData["DIASEMANA"] = "Mañana martes!!!";
            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Email = "model@gmail.com";
            persona.Edad = 77;
            return View(persona);
        }

        //VAMOS A RECIBIR DOS PARAMETROS
        public IActionResult VistaControladorGet
            (string app, int? version)
        {
            //AHORA LA VERSION ES OPCIONAL
            if (version is null)
            {

            }
                //DIBUJAMOS EN LA VISTA LOS PARAMETROS RECIBIDOS
            ViewData["DATOS"] = "Application: " + app.ToUpper()
                    + ", Version: " + version.GetValueOrDefault();

            return View();
        }
    }
}
