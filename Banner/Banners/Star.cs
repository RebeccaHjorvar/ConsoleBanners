using BannerConsole.Interfaces;

namespace BannerConsole.Banners
{
    public class Star : IBanner
    {
        public string BannerText { get; set; }
        public string Style { get; set; }

        public Star(string bannerText)
        {
            BannerText = bannerText;  
            Style = "******************************";
        }
    }
}
