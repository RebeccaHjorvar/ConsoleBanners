namespace ConsoleBanner
{
    public class StarDecorator : BannerDecorator
    {
        public StarDecorator(IBanner banner) : base(banner) { }

        public override string GetBannerType()
        {
            string type = base.GetBannerType();
            type += "\r\n********************";
            return type;
        }
    }
}
