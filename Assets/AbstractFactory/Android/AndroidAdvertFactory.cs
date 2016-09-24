using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.AbstractFactory.Android
{
    public class AndroidAdvertFactory : AbstractAdvertFactory
    {
        public override IBannerAdvert CreateBannerAdvert()
        {
            return new AndroidBannerAdvert();
        }

        public override IVideoAdvert CreateVideoAdvert()
        {
            return new AndroidVideoAdvert();
        }
    }
}
