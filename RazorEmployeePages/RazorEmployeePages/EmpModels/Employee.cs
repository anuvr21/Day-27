using System.ComponentModel.DataAnnotations;

namespace RazorEmployeePages.EmpModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public string? Department { get; set; }
        public decimal Salary { get; set; }
    }
}
