using UnityEngine;
using System.Collections;
using Assets.AbstractFactory;
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

            var advert = _advertFactory.CreateAdvert();
            Debug.Log(advert);
            advert.Show();
        }
    }
}
