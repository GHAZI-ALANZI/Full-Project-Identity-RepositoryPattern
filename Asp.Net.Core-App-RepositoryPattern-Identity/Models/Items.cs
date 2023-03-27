using System.ComponentModel.DataAnnotations;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
