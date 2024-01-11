using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdatbazisAPI.Models.Dtos
{
    public class Nemzetiseg
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SzerzoNemzetisege { get; set; }
    }
}
