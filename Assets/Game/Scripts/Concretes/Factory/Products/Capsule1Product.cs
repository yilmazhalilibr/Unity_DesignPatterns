using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class Capsule1Product : IProduct
    {
        private string _capsuleName;
        private GameObject _capsule;

        public string ProductName => _capsuleName;
        public GameObject ProductGameObject => _capsule;

        public Capsule1Product(GameObject capsule)
        {
            _capsuleName = "Capsule1";
            _capsule = capsule;
        }

        
    }
}

