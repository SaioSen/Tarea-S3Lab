using Microsoft.AspNetCore.Mvc;
using Tarea_S3Lab.Models;
using Tarea_S3Lab.Data;


namespace Tarea_S3Lab.Controllers
{
    public class AlumnoController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AlumnoController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();

        }

        public IActionResult Crear(Alumno objAlumno)
        {

            _context.Add(objAlumno);
            _context.SaveChanges();
            ViewData["Message"] = "Alumno Registrado";

            return View("Index");
        }

    }
}