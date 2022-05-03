using Microsoft.AspNetCore.Mvc;
using restaurante.Models;

namespace restaurante.Controllers
{
    public class ControllerBodega : Controller
    {
        //Conexion con = new Conexion(@"DESKTOP-386DLNS\SQLEXPRESS", "ivan", "solivan802", "practica");
        BodegaMetodos metodos = new BodegaMetodos(@"DESKTOP-386DLNS\SQLEXPRESS", "ivan", "solivan802", "practica");
        public IActionResult Index()
        {
           
            List<Bodega> registro = metodos.listaBodega();
            return View(registro);
        }

        public IActionResult Create()
        {
            return View();
        }
        
    }
}
