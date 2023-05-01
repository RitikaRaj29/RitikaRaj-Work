using System.ComponentModel.DataAnnotations;

namespace DemoAssignment.Models
{
    public class Employee
    {
       [Key]
       public int id { get; set; }
       public string EmpName { get; set; }
       
    }
}
