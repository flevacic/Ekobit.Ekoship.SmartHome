using System.ComponentModel.DataAnnotations;

namespace Ekobit.Ekoship.SmartHome.Data.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Symbol { get; set; }
    }
}
