using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.AbstractFactory.iOS
{
    public class iOSAdvertFactory : AbstractAdvertFactory
    {
        public override IBannerAdvert CreateBannerAdvert()
        {
            return new iOSBannerAdvert();
        }

        public override IVideoAdvert CreateVideoAdvert()
        {
            return new iOSVideoAdvert();
        }
    }
}
