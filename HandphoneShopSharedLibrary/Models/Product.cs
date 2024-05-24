using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace HandphoneShopSharedLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required, Range(0.1, 99999.999)]
        public decimal Price { get; set; }
        [Required, DisplayName("Product Image")]
        public string? Base64Img { get; set; }
        public int Quality { get; set; }
        public bool Featured { get; set; }
        public DateTime DateUploaded { get; set; } = DateTime.Now;
    }
}
