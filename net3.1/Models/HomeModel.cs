
using System.ComponentModel.DataAnnotations;

namespace net3._1.Models
{
    public class CarouselFirst
    {
        public string Image { get; set; }
        public string ImageMobile { get; set; }
        public CarouselFirst() { }

        public CarouselFirst(string Image, string ImageMobile)
        {
            this.Image = Image;
            this.ImageMobile = ImageMobile;
        }

    }

    public class ShowCase
    {
        public string Img { get; set; }
        public ShowCase(string Img) { this.Img = Img; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Img { set; get; }

        public double Price { get; set; }
        public Product(string Name, string Category, string Description, string Img, double Price) {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.Img = Img;
            this.Price = Price;
        }

    }
}
