using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } 
        public DateTime? DeletedAt { get;set; }
        public bool Isdeleted { get; set; } = false;


        public string CreateBy { get; set; } = string.Empty;
        public string UpdateBy { get; set; } = string.Empty;
        public string DeleteBy { get; set; } = string.Empty;

        public int UserId { get; set; }
        public virtual Users User { get; set; } = new Users();

    }
}
