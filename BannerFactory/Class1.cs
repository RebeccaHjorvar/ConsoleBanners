namespace BannerFactory
{
    interface IBanner
    {
        string GetBannerType(string bannerText);
    }

    class Banner : IBanner
    {
        public string GetBannerType(string bannerText)
        {
            return " " + bannerText;
        }
    }

    class BannerDecorator : IBanner
    {
        private IBanner _banner;
        public BannerDecorator(IBanner banner)
        {
            _banner = banner;
        }
        public virtual string GetBannerType(string bannerText)
        {
            return _banner.GetBannerType(bannerText);
        }
    }

    class StarDecorator : BannerDecorator
    {
        public StarDecorator(IBanner banner) : base(banner) { }

        public override string GetBannerType(string bannerText)
        {
            string type = base.GetBannerType(bannerText);
            type += "\r\n********************";
            return type;
        }
    }
    class DashDecorator : BannerDecorator
    {
        public DashDecorator(IBanner banner) : base(banner) { }

        public override string GetBannerType(string bannerText)
        {
            string type = base.GetBannerType(bannerText);
            type += "\r\n--------------------";
            return type;
        }
    }
}