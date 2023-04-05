using System.ComponentModel.DataAnnotations;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public ICollection<Item>? Items { get; set; }
    }
}
