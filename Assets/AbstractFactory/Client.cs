using UnityEngine;
using System.Collections;
using Assets.AbstractFactory;
using Assets.AbstractFactory.Android;
using Assets.AbstractFactory.iOS;
using System;

namespace Assets.AbstractFactory
{
    public class Client : MonoBehaviour
    {
        public string _whatToMake = "iOS";

        private AbstractAdvertFactory _advertFactory;

        // Use this for initialization
        void Start()
        {
            switch (_whatToMake)
            {
                case "iOS":
                    _advertFactory = new iOSAdvertFactory();
                    break;
                case "Android":
                    _advertFactory = new AndroidAdvertFactory();
                    break;
                default:
                    throw new Exception("Unable to find advert factory implementation");
            }

            var bannerAdvert = _advertFactory.CreateBannerAdvert();
            Debug.Log(bannerAdvert);
            bannerAdvert.Show();
            bannerAdvert.Hide();

            var videoAdvert = _advertFactory.CreateVideoAdvert();
            Debug.Log(videoAdvert);
            videoAdvert.Play();
            videoAdvert.Stop();
        }
    }
}
