using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace C42_G02_MVC06.Models
{
    public class Department : BaseEntity
    {
        [Required(ErrorMessage = "code is requride !!")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is requride !!")]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
