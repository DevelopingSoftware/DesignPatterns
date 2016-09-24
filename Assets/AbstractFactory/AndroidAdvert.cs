using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.AbstractFactory
{
    public class AndroidAdvert : IAdvert
    {
        public void Show()
        {
            // Call your native Android API here

            Debug.Log("Showing Android Advert");
        }
    }
}
