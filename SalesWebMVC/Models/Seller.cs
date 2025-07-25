﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }



        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} must contain between {2} and {1} characters")]
        public string Name { get; set; }




        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }




        [Required(ErrorMessage = "{0} required")]
        [Display (Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }




        [Required(ErrorMessage = "{0} required")]
        [Range(100.00, 50000.00, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        [ValidateNever]
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
