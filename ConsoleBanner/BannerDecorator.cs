namespace ConsoleBanner
{
    public class BannerDecorator : IBanner
    {
        private IBanner _banner;
        public BannerDecorator(IBanner banner)
        {
            _banner = banner;
        }
        public virtual string GetBannerType()
        {
            return _banner.GetBannerType();
        }
    }
}
