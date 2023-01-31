using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleadosContext context;
        public EmpleadoController(DBEmpleadosContext context)
        {
            this.context = context;
        }

        //MOSTRAR TODOS LOS EMPLEADOS

        [HttpGet]
        public IActionResult Index()
        {
            var empleados = context.Empleados.ToList();
            return View(empleados);
        }

        //INSERTAR UN EMPLEADO
        [HttpGet]

        public ActionResult Insertar()
        {
            Empleado empleado = new Empleado();
            return View("Insertar", empleado);
        }

        [HttpPost]
        public ActionResult Insertar(Empleado empleado)
        {

            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        //Lista por titulo

        [HttpGet]
        public IActionResult TraerTitulos(string titulo)
        {
            List<Empleado> empleados = (from e in context.Empleados
                                            where e.Titulo == titulo
                                            select e).ToList();
            return View(empleados);
        }


        //Eliminar

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empleado = TraerUno(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", empleado);
            }
        }

        private Empleado TraerUno(int id)
        {
            return context.Empleados.Find(id);
        }

        [ActionName("Delete")]
        [HttpPost]

        public ActionResult DeleteConfirmed(int id)
        {
            var empleado = TraerUno(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]

        public ActionResult Details(int id)
        {
            Empleado empleado = TraerUno(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", empleado);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Empleado empleado = TraerUno(id);
            return View("Edit", empleado);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(int id, Empleado empleado)
        {
            if (id != empleado.Id)
            {
                return NotFound();
            }
            else
            {
                context.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }

}
