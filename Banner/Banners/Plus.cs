using BannerConsole.Interfaces;

namespace BannerConsole.Banners
{
    public class Plus : IBanner
    {
        public string BannerText { get; set; }
        public string Style { get; set; }

        public Plus(string bannerText)
        {
            BannerText = bannerText;
            Style = "++++++++++++++++++++++++++++++";
        }
    }
}
