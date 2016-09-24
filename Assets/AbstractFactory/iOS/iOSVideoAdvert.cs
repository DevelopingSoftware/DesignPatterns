using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.AbstractFactory.iOS
{
    public class iOSVideoAdvert : IVideoAdvert
    {
        public void Play()
        {
            Debug.Log("Playing iOS Video Advert");
        }

        public void Stop()
        {
            Debug.Log("Stop playing iOS Video Advert");
        }
    }
}
