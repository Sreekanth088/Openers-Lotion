namespace ProductStore.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? ProductName { get; set; }
        [Display(Name = "Item Form")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? ItemForm { get; set; }
        [Display(Name = "Skin Type")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? SkinType { get; set; }
        [Display(Name = "Quantity (mL)")]
        public int? Quantity { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(150)]
        public string? Description { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public decimal? Review { get; set; }
    }
}