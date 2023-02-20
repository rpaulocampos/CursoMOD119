using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMOD119.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        //[Display(Name = "Date of Birth")]
        //public DateTime BirthDate { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        //[Display(Name = "Age")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int Age { get { return DateTime.Today.Year - BirthDate.Year; } }

        [Display(Name = "Age")]
        public int age { get; set; }
    }
}
