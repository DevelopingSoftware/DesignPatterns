using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.AbstractFactory
{
    public abstract class AbstractAdvertFactory
    {
        public abstract IAdvert CreateAdvert();
    }
}
