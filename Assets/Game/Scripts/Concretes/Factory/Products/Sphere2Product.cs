using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class Sphere2Product : IProduct
    {
        private GameObject _sphere;
        private string _productName;

        public string ProductName => _productName;

        public GameObject ProductGameObject => _sphere;

        public Sphere2Product(GameObject sphere)
        {
            _productName = "Sphere2";
            _sphere = sphere;
        }

    }
}

