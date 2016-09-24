using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.AbstractFactory.iOS
{
    public class iOSBannerAdvert : IBannerAdvert
    {
        public void Show()
        {
            // TODO: Call into your native advert displaying code here
            Debug.Log("Showing iOS Banner Advert");
        }

        public void Hide()
        {
            Debug.Log("Hide iOS Banner Advert");
        }
    }
}
