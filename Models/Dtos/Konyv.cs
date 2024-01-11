using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdatbazisAPI.Models.Dtos
{
    public class Konyv
    {
        [Key]
        public Guid Id { get; set; }
        [Key]
        public Guid SzerzoId { get; set; }
        public Szerzo? szerzo { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Cím { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Mufaj { get; set; }
        [Required]
        [Column]
        public int kiadaseve { get; set; }
    }
}
