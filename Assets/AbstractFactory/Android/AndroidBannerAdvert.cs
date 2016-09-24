using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.AbstractFactory.Android
{
    public class AndroidBannerAdvert : IBannerAdvert
    {
        public void Show()
        {
            // Call your native Android API here
            Debug.Log("Showing Android Banner Advert");
        }

        public void Hide()
        {
            Debug.Log("Hiding Android Banner Advert");
        }

    }
}
