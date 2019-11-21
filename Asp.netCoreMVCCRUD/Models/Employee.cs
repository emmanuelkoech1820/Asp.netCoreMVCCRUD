using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage =  "This field is required.")]

        [DisplayName("First Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(10)")]


        [DisplayName("Employee Code")]
        public string  EmpCode { get; set; }   
        [Column(TypeName = "nvarchar(100)")]

        public string Position { get; set; }        
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public  string OfficeLocation { get; set; }

    }
}
