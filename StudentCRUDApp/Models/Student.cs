using System.ComponentModel.DataAnnotations;
namespace StudentCRUDApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter your fullname")]
        public string FullName { get; set; }

        [Range(16, 50, ErrorMessage = "Ages 16-50 only")]
        public int Age { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your Regno")]
        public string Regno { get; set; }
        [Required(ErrorMessage = "Please enter your Courses")]
        public string Courses { get; set; }

        [Required(ErrorMessage = "Please enter your Department")]
        public string Department { get; set; }

        [RegularExpression(@"^[MF]+$", ErrorMessage = "Select any one option")]
        public Char Sex { get; set; }
    }
}


      
