using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdatbazisAPI.Models.Dtos
{
    public class Szerzo
    {
        [Key]
        public Guid Id { get; set; }
        [Key]
        public Guid NemzetisegId { get; set; }
        public Nemzetiseg? nemzetiseg { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nev { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nem { get; set; }
    }
}
