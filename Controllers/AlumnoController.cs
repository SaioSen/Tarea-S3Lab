using Microsoft.AspNetCore.Mvc;
using Tarea_S3Lab.Models;


namespace Tarea_S3Lab.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index()
        {
            return View();

        }

        public IActionResult Crear(Alumno objventa)
        {





            ViewData["Message"] = "Alumno Registrado";

            return View("Index");
        }

    }
}