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
}
