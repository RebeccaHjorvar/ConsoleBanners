using BannerConsole.Enums;
using BannerConsole.Interfaces;

namespace BannerConsole;

/// <summary>
/// Creates a simple banner for your console application. Simply select a type and compose your text.
/// </summary>
/// <param name="type">"None", "Star", "Plus" </param>
/// <param name="bannerText">Text for the banner</param>
public static class Create
{
    public static void Banner(string type, string bannerText)
    {
        if (bannerText.Length < 1)
        {
            bannerText = "You forgot to write a banner text";
        }

        switch (type.ToUpper())
        {
            case "STAR":
                IBanner? banner = BannerFactory.CreateBanner(BannerTypes.Star, bannerText);
                Console.WriteLine();
                Console.WriteLine(banner.Style);
                Console.WriteLine();
                Console.WriteLine("  " + banner.BannerText);
                Console.WriteLine();
                Console.WriteLine(banner.Style);
                Console.WriteLine();
                break;
            case "PLUS":
                IBanner? banner2 = BannerFactory.CreateBanner(BannerTypes.Plus, bannerText);
                Console.WriteLine();
                Console.WriteLine(banner2.Style);
                Console.WriteLine();
                Console.WriteLine("  " + banner2.BannerText);
                Console.WriteLine();
                Console.WriteLine(banner2.Style);
                Console.WriteLine();
                break;

            default:
                IBanner? banner3 = BannerFactory.CreateBanner(BannerTypes.None, bannerText);
                Console.WriteLine();
                Console.WriteLine(banner3.Style);
                Console.WriteLine();
                Console.WriteLine("  " + banner3.BannerText);
                Console.WriteLine();
                Console.WriteLine(banner3.Style);
                Console.WriteLine();
                break;
        };
    }
}






