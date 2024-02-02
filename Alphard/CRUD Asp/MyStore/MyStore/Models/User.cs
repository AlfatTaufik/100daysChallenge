using System.ComponentModel.DataAnnotations;
namespace MyStore.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public int Stock { get; set; }
        [Range(0, 9999.99)]
        public decimal Price { get; set; }
    }
}
