namespace net3._1.Models
{
    public class TabKey
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public bool IsHighlighted { get; set; }



        public TabKey(string Name, string Link, bool IsHighlighted = false)
        {
            this.Name = Name;
            this.Link = Link;
            this.IsHighlighted = IsHighlighted;
        }
        public TabKey(string Name, bool IsHighlighted = false)
        {
            this.Name = Name;
            this.IsHighlighted = IsHighlighted;
        }
    }


}
