using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

    public class Image
    {
        public string Img { get; set; }
        protected Image(string Img) { this.Img = Img; }
    }

    public class ShowCase : Image
    {
        public ShowCase(string Img) : base(Img)
        {

        }
    }

    public class Brand : Image
    {
        public Brand(string Img) : base(Img)
        {

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Img { set; get; }

        public double Price { get; set; }
        public Product(string Name, string Category, string Description, string Img, double Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.Img = Img;
            this.Price = Price;
        }

    }


        public class TabValue
        {
            public string Name { get; set; }
            public string Link { get; set; }

            public TabValue(string Name, string Link)
            {
                this.Name = Name;
                this.Link = Link;
            }
        }


    public class TabKey
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public bool IsRed { get; set; }

        public TabKey(string Name, string Link, bool IsRed = false)
        {
            this.Name = Name;
            this.Link = Link;
            this.IsRed = IsRed;
        }
        public TabKey(string Name, bool IsRed = false)
        {
            this.Name = Name;
            this.IsRed = IsRed;
        }
    }


}
