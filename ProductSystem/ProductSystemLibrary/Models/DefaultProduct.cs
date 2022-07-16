using ProductSystemLibrary.Enums;
using ProductSystemLibrary.Interfaces;

namespace ProductSystemLibrary.Models
{
    public class DefaultProduct : IDefaultProduct
    {
        public DefaultProduct(ProductDescription productDescription)
        {
            this.ProductDescription = productDescription;
        }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public double RegularPrice { get; set; }
        public double SalePrice { get; set; }
        public virtual StockStatus StockStatus { get; set; }
        public double RatingCount { get; set; }
        public string ProductURL { get; set; }
        public string ImageURL { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public virtual ProductSize? ProductSize { get; set; }
    }
}
