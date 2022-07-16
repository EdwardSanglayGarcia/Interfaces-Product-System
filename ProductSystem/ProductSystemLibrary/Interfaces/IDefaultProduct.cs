using ProductSystemLibrary.Enums;
using ProductSystemLibrary.Models;

namespace ProductSystemLibrary.Interfaces
{
    public interface IDefaultProduct
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public double RegularPrice { get; set; }
        public double SalePrice { get; set; }
        public  StockStatus StockStatus { get; set; }
        public double RatingCount { get; set; }
        public string ProductURL { get; set; }
        public string ImageURL { get; set; }
        public  ProductSize? ProductSize { get; set; }
        public ProductDescription ProductDescription { get; set; }
    }
}
