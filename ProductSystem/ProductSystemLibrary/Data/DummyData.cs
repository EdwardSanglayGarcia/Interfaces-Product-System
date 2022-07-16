using ProductSystemLibrary.Interfaces;
using ProductSystemLibrary.Models;
using ProductSystemLibrary.Enums;
using System.Drawing;

namespace ProductSystemLibrary.Data
{
    public class DummyData
    {
        public List<IDefaultProduct> GenerateDummyData()
        {
            List<IDefaultProduct> productList = new List<IDefaultProduct>();

            productList.Add
            (
            new DefaultProduct(
            new ProductDescription(1.11, 3.33, 4.44, 5.55)
            {
                ProductDescriptionId = 1,
                Category =
                {
                        Enum.GetName(typeof(ProductCategory),3),
                        Enum.GetName(typeof(ProductCategory),1),
                },
                Color = Color.Orange,
                UPC = "123FDFFFYYT75"
            }
            )
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Electronic Building Set Toys",
                Brand = "Small Lego Aboitiz Corporation",
                RegularPrice = 1500.95,
                SalePrice = 1200.95,
                StockStatus = StockStatus.OutOfStock,
                RatingCount = 4.95,
                ProductURL = @"https://www.macys.com/shop/all-toys/Toy_type/Building%20Toys?id=260274&lid=toysrus_toytype-buildingsettoys",
                ImageURL = @"https://assets.mcomnyapps.net/toys-r-us/2022june/images/Toy%20type-2.png?&Building%20Set%20Toys",
                ProductSize = ProductSize.Small
            }
            );

            productList.Add
            (
            new DefaultProduct(
            new ProductDescription(22, 3, 90, 50)
            {
                ProductDescriptionId = 1,
                Category =
                {
                        Enum.GetName(typeof(ProductCategory),3),
                        Enum.GetName(typeof(ProductCategory),1),
                },
                Color = Color.Yellow,
                UPC = "123FDFFFY31"
            }
            )
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Electronic Building Set Toys",
                Brand = "Lego Aboitiz Corporation",
                RegularPrice = 1500.95,
                SalePrice = 1200.95,
                StockStatus = StockStatus.InStock,
                RatingCount = 4.95,
                ProductURL = @"https://www.macys.com/shop/all-toys/Toy_type/Building%20Toys?id=260274&lid=toysrus_toytype-buildingsettoys",
                ImageURL = @"https://assets.mcomnyapps.net/toys-r-us/2022june/images/Toy%20type-2.png?&Building%20Set%20Toys",
                ProductSize = ProductSize.Medium | ProductSize.Large
            }
            );


            productList.Add
            (
            new KitchenProduct
            (
                new ProductDescription(1.11, 3.33, 4.44, 5.55)
                {
                    ProductDescriptionId = 1,
                    Category =
                            {
                                    Enum.GetName(typeof(ProductCategory),3),
                                    Enum.GetName(typeof(ProductCategory),1),
                            },
                    Color = Color.Blue,
                    UPC = "1234567SAS2157"
                }
            )
            {
                ProductId = Guid.NewGuid(),
                ProductName = "All in One Electric Knife for Cooking and Baking",
                Brand = "Mitsubishi Cooking Appliance",
                RegularPrice = 15000.92,
                SalePrice = 12000.00,
                StockStatus = StockStatus.InStock,
                RatingCount = 4.95,
                ProductURL = @"https://www.macys.com/shop/all-toys/Toy_type/Building%20Toys?id=260274&lid=toysrus_toytype-buildingsettoys",
                ImageURL = @"https://assets.mcomnyapps.net/toys-r-us/2022june/images/Toy%20type-2.png?&Building%20Set%20Toys",
                ProductSize = ProductSize.Medium | ProductSize.Large,
                SubCategories =
                    {
                            "Bakeware",
                            "Cookware",
                            "Kitchen Gadgets",
                            "All Kitchen"
                    }
            }
            );

            productList.Add
            (
            new KitchenProduct
            (
                new ProductDescription(1.11, 3.33, 4.44, 5.55)
                {
                    ProductDescriptionId = 1,
                    Category =
                            {
                                    Enum.GetName(typeof(ProductCategory),3),
                                    Enum.GetName(typeof(ProductCategory),1),
                            },
                    Color = Color.Red,
                    UPC = "12345678SASAS"
                }
            )
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Kopimo Coffee Maker",
                Brand = "Selecta Coffee Incorporated",
                RegularPrice = 21000.04,
                SalePrice = 13000.00,
                StockStatus = StockStatus.InStock,
                RatingCount = 5.00,
                ProductURL = @"https://www.macys.com/shop/all-toys/Toy_type/Building%20Toys?id=260274&lid=toysrus_toytype-buildingsettoys",
                ImageURL = @"https://assets.mcomnyapps.net/toys-r-us/2022june/images/Toy%20type-2.png?&Building%20Set%20Toys",
                ProductSize = ProductSize.Small | ProductSize.Medium | ProductSize.Large,
                SubCategories =
                    {
                            "Coffee Maker",
                    }
            }
            );

            return productList;

        }

    }
}
