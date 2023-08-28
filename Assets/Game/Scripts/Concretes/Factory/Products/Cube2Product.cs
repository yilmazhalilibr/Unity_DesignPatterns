using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;


namespace Unity_DesignPatterns.Concretes
{

    public class Cube2Product : IProduct
    {
        private GameObject _cube;
        private string _productName;
        public string ProductName => _productName;
        public GameObject ProductGameObject => _cube;

        public Cube2Product(GameObject cube)
        {
            _productName = "Cube 2";
            _cube = cube;

        }

    }

}

