using ProductSystemLibrary.Data;
using System.Text;
using ProductSystemLibrary.Interfaces;
using System.Text.RegularExpressions;

namespace ProductSystemLibrary.Actions
{
    public class Actions : IActions
    {
        public List<IDefaultProduct> AddSampleData()
        {
            DummyData d = new DummyData();
            return d.GenerateDummyData();
        }

        public void GenerateCSV(List<IDefaultProduct> products)
        {
            DefaultData DEFAULT = new DefaultData();
            var path = DEFAULT.desktopPath;
            string[] columns =
            {
                "Product ID",
                "Product Name",
                "Brand",
                "Regular Price",
                "Sale Price",
                "Rating Count",
                "Available Sizes",
                "UPC",
                "Color",
                "Categories",
                "Stock Status",
                "Sub Categories"
            };

            StringBuilder stringBuilder = new StringBuilder();

            if (!File.Exists(path))
            {
                // Create a file to write to.

                stringBuilder.AppendLine(string.Join(",", columns)+Environment.NewLine);

                foreach (var data in products)
                {
                    string generateData =
                    (
                        $"{data.ProductId}," +
                        $"{data.ProductName}," +
                        $"{data.Brand}," +
                        $"{data.RegularPrice}," +
                        $"{data.SalePrice}," +
                        $"{data.RatingCount}," +
                        $"\"{data.ProductSize}\"," +
                        $"{data.ProductDescription.UPC}," +
                        $"{data.ProductDescription.Color}," +
                        $"{Regex.Replace(data.StockStatus.ToString(), "(\\B[A-Z])", " $1")},"+
                        $"\"{String.Join(", ", data.ProductDescription.Category)}\","
                    );

                    if (data is IKitchenProduct kitchen)
                    {
                        generateData += $"\"{String.Join(", ", kitchen.SubCategories)}\"";
                    }

                    stringBuilder.AppendLine(generateData);
                }
                File.WriteAllText(path, stringBuilder.ToString());
            }
            Console.WriteLine("Done generating the CSV document!");
        }

        public void DisplayConsoleData(List<IDefaultProduct> products)
        {

            foreach (var data in products)
            {
                Console.WriteLine($"Product: {data.ProductId.ToString().ToUpper()} - {data.ProductName}");
                Console.WriteLine($"Brand: {data.Brand}");
                Console.WriteLine($"Size/s: {data.ProductSize}");
                Console.WriteLine($"Price: {data.RegularPrice}");
                Console.WriteLine($"Color: {data.ProductDescription.Color}");
                Console.WriteLine($"UPC: {data.ProductDescription.UPC}");
                if (data is IKitchenProduct kitchen)
                {
                    Console.WriteLine(String.Join(", ",kitchen.SubCategories));
                }
                Console.WriteLine();
            }
        }

    }
}
