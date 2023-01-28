using System.ComponentModel.DataAnnotations;

namespace BlackCarrot.Data.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? ProductPrice { get; set; }
    }
}
