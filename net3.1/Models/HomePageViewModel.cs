using System.Collections.Generic;
using static net3._1.Models.Header;

namespace net3._1.Models
{
    public class HomePageViewModel
    {
        public List<CarouselFirst> carousels;
        public List<ShowCase> showCases;
        public List<Product> products;
        public List<Brand> brands;
        public Dictionary<string, TabValue[]> headerTabs;

    }
}
