using net3._1.Data;
using net3._1.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace net3._1.Services
{
    public class CarouselServices
    {
        private readonly Net3_1Context _context;
        public CarouselServices(Net3_1Context _context) {
        this._context = _context;
        }
        public List<CarouselFirst> GetCarouselList()
        {
            return _context.carouselFirsts.Where(e => e.Id == 1).ToList();
            //return new List<CarouselFirst>() {
            //     new CarouselFirst("gallery-desktop-01.jpg","gallery-mobile-01.jpg"),
            //     new CarouselFirst("gallery-desktop-02.jpg","gallery-mobile-02.jpg"),
            //     new CarouselFirst("gallery-desktop-03.jpg","gallery-mobile-03.jpg"),
            //     new CarouselFirst("gallery-desktop-04.jpg","gallery-mobile-04.jpg"),
            //     new CarouselFirst("gallery-desktop-05.jpg","gallery-mobile-05.jpg"),
            //     new CarouselFirst("gallery-desktop-06.jpg","gallery-mobile-06.jpg"),
            //     new CarouselFirst("gallery-desktop-07.jpg","gallery-mobile-07.jpg"),
            //     new CarouselFirst("gallery-desktop-08.jpg","gallery-mobile-08.jpg")
            //};

        }

        public List<ShowCase> GetShowCases()
        {
            return new List<ShowCase>() {
            new ShowCase("showcase-01"),
            new ShowCase("showcase-02"),
            new ShowCase("showcase-03"),
            new ShowCase("showcase-04"),
            new ShowCase("showcase-05"),
            new ShowCase("showcase-06")
        };
        }

        public List<Product> GetProducts()
        {
            return new List<Product>() {
            new Product("Esempio 1","Oda in between","Lampada a terra LEd","product-01.jpg",1928.20),
            new Product("Esempio 2 ","Oda in between","Lampada a terra LEd","product-02.jpg",21),
            new Product("Esempio 3 ","Oda in between","Lampada a terra LEd","product-03.jpg",21),
            new Product("Esempio 4","Oda in between","Lampada a terra LEd","product-04.jpg",500.00),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-05.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-06.jpg",219.29),
            new Product("Esempio 2","Oda in between","Lampada a terra LEd","product-07.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-08.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-09.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-10.jpg",91.99),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-11.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-12.jpg",43.17),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-13.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-14.jpg",21),
            new Product("pulpo","Oda in between","Lampada a terra LEd","product-15.jpg",21),

        };
        }

        public List<Brand> GetBrands()
        {
            List<Brand> ret = new List<Brand>();
            for (int i = 1; i < 24; i++)
            {
                ret.Add(new Brand($"brand-{(i.ToString().Length == 1 ? ("0" + i) : i.ToString())}.gif"));
            };
            return ret;
        }


        public Dictionary<TabKey, TabValue[]> GetHeaderTabs()
        {
            Dictionary<TabKey, TabValue[]> dict = new Dictionary<TabKey, TabValue[]>
            {
                {new TabKey("Arredo"), new TabValue[] {
                 new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona giorno","")
                }    }, 

                {new TabKey("Bagno"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona x","")
                }    },

                 {new TabKey("Cucina"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona y","")
                }    },

                  {new TabKey("Illuminazione"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona z","")
                }    },

                   {new TabKey("Outdoor"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },


                  {new TabKey("Ufficio"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },

                            {new TabKey("Contract"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                  {new TabKey("Decor"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                        {new TabKey("Finiture"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                              {new TabKey("Edilizia"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                                    {new TabKey("Lifestyle"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                                          {new TabKey("Marchi","https://www.google.it"), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                                                {new TabKey("Promo",true), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    },
                                                                      {new TabKey("Outlet","https://www.google.it",true), new TabValue[] {
                  new TabValue("Divani e poltrone","Link"),new TabValue("Tavoli e sedie","Link"), new TabValue("Zona t","")
                }    }
            };

            return dict;

        }
    }

}


