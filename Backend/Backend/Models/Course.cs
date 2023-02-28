using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public enum Levels { 
        Basic,
        Medium,
        Advanced, 
        Expert 
    };
    public class Course : BaseEntity
    {
        [Required, StringLength(50)] 
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;

        public Levels Level { get; set; }

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public Index Index { get; set; } = new Index();
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
