using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Index : BaseEntity
    {
        [Required]
        public string Chapters { get; set; } = string.Empty;

        
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();   

    }
}
