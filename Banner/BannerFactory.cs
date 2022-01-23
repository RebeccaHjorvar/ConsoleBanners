using BannerConsole.Banners;
using BannerConsole.Enums;
using BannerConsole.Interfaces;

namespace BannerConsole
{
    public static class BannerFactory
    {
        public static IBanner? CreateBanner(BannerTypes type, string bannerText) => type switch
        {
            BannerTypes.None => new None(bannerText),
            BannerTypes.Star => new Star(bannerText),
            BannerTypes.Plus => new Plus(bannerText),
            _ => null,
        };
    }
}
