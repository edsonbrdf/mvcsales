using Microsoft.AspNetCore.Mvc;
using SaleswebMVC.Models;

namespace SaleswebMVC.Controllers 
    {
    public class DepartmentsController : Controller 
        {
        public IActionResult Index()
            {

            List <Departament> list = new List<Departament>();

            list.Add(new Departament { Id = 1, Name="Eletronics" });
            list.Add(new Departament { Id = 2, Name = "Faturamento" });


            return View(list);
        }
    }
}
