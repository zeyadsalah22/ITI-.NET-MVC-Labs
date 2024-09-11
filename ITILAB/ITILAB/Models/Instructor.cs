using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITILAB.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string Address { get; set; }
        [ForeignKey("Dept")]
        public int DeptId { get; set; }
        public Department Dept { get; set; }
    }
}
