using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataLib
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }


    }
}
