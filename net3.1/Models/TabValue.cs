namespace net3._1.Models
{
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
}
