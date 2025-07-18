﻿namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sale) 
        {
            Sales.Add(sale);
        }
        public void RemoveSales(SalesRecord sale) 
        {
            Sales.Remove(sale);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            double amount = Sales.Where(s => s.Date >= initial && s.Date <= final).Select(n => n.Amount).Sum();
            return amount;
        }
    }
}
