using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.AbstractFactory
{
    public class AndroidAdvertFactory : AbstractAdvertFactory
    {
        public override IAdvert CreateAdvert()
        {
            return new AndroidAdvert();
        }
    }
}
