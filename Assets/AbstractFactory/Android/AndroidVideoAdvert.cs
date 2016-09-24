using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.AbstractFactory.Android
{
    public class AndroidVideoAdvert : IVideoAdvert
    {
        public void Play()
        {
            Debug.Log("Playing Android Video Advert");
        }

        public void Stop()
        {
            Debug.Log("Stop playing Android Video Advert");
        }
    }
}
