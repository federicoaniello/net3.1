using System.Collections.Generic;

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

        public static List<CarouselFirst> getCarouseLList(){


            return new List<CarouselFirst>() {
                 new CarouselFirst("gallery-desktop-01.jpg","gallery-mobile-01.jpg"),
                 new CarouselFirst("gallery-desktop-02.jpg","gallery-mobile-02.jpg"),
                 new CarouselFirst("gallery-desktop-03.jpg","gallery-mobile-03.jpg"),
                 new CarouselFirst("gallery-desktop-04.jpg","gallery-mobile-04.jpg"),
                 new CarouselFirst("gallery-desktop-05.jpg","gallery-mobile-05.jpg"),
                 new CarouselFirst("gallery-desktop-06.jpg","gallery-mobile-06.jpg"),
                 new CarouselFirst("gallery-desktop-07.jpg","gallery-mobile-07.jpg"),
                 new CarouselFirst("gallery-desktop-08.jpg","gallery-mobile-08.jpg")
            };

        }

    }
}
