namespace net3._1.Models
{
    public class Product
    {
        public int Id { get; set; }
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

}
