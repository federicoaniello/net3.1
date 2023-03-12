using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net3._1.Models
{
    [Table("carousels")]
    public class CarouselFirst
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string ImageMobile { get; set; }
        public CarouselFirst() { }

        public CarouselFirst(string Image, string ImageMobile)
        {
            this.Image = Image;
            this.ImageMobile = ImageMobile;
        }

    }
}
