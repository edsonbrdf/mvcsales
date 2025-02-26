using System.Collections.Generic;
using System;
using SaleswebMVC.Migrations;
using System.Linq;

namespace SaleswebMVC.Models 
    {
    public class Department 
    
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection <Seller> Seller { get; set; } = new List<Seller>();


        public Department() { 
                        
        }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) {

            Seller.Add(seller);
        }

        public void RemoveSeller(Seller seller) {

            Seller.Remove(seller);
        }
        public double TotalSales(DateTime inicial, DateTime final) {

            return Seller.Sum(seller=> seller.TotalSales(inicial, final));



        }




    }

    
        
}
