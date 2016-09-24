using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.AbstractFactory
{
    public class iOSAdvert : IAdvert
    {
        public void Show()
        {
            // TODO: Call into your native advert displaying code here
            Debug.Log("Showing iOS Advert");
        }
    }
}
