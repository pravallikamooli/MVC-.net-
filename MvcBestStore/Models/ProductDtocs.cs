using System.ComponentModel.DataAnnotations;

namespace MvcBestStore.Models
{
    public class ProductDtocs
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Brand { get; set; } = "";
        [Required]
        public string Category { get; set; } = "";
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = "";

        public IFormFile? Imagefile { get; set; } 
    }
}