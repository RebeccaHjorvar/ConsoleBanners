using BannerConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BannerConsole.Banners;

    public class None : IBanner
    {
        public string BannerText { get; set; }
        public string Style { get; set; }

        public None(string bannerText)
        {
            BannerText = bannerText;
            Style = " ";

        }
    }