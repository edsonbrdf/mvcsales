using System.Collections.Generic;
using System.Linq;

namespace SaleswebMVC.Models {
    public class Seller {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthdate { get; set; }
        public double basesalary { get; set; }
        public Department departament { get; set; }

        public ICollection<SalesRecord> Sales  = new List<SalesRecord>();

        public Seller() { 
        
        }

        public Seller(int id, string name, string email, DateTime birthdate, double basesalary, Department departament) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthdate = birthdate;
            this.basesalary = basesalary;
            this.departament = departament;
        }

        public void AddSales(SalesRecord sr) { 

            Sales.Add(sr);          
        }

        public void RemoSales(SalesRecord sr) {

            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) {

            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        
        }
    }
}
