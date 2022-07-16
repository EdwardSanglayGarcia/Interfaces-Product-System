using System.Drawing;

namespace ProductSystemLibrary.Models
{
    public class ProductDescription
    {
        public ProductDescription(double Weight, double Height, double Width, double Depth)
        {
            Category = new List<string>();

            this.weight = Weight;
            this.height = Height;
            this.width = Width;
            this.depth = Depth;
        }

        public int ProductDescriptionId { get; set; }
        private double weight;
        private double height;
        private double width;
        private double depth;
        public ICollection<string> Category { get; set; }
        public Color? Color { get; set; }
        public string UPC { get; set; }
    }
}
