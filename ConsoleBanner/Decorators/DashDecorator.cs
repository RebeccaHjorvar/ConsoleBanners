namespace ConsoleBanner
{
    public class DashDecorator : BannerDecorator
    {
        public DashDecorator(IBanner banner) : base(banner) { }
        public override string GetBannerType()
        {
            string type = base.GetBannerType();
            type += "\r\n--------------------";
            return type;
        }
    }
}
