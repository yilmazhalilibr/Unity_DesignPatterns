using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class SphereFactory : BaseFactory
    {
        [SerializeField] List<GameObject> _spherePrefabs = new List<GameObject>();

        public const int SPHERE_TYPE_1 = 0;
        public const int SPHERE_TYPE_2 = 1;

        public override int Count => _spherePrefabs.Count;

        public override IProduct GetProduct(int productType, Vector3 position)
        {
            switch (productType)
            {
                case SPHERE_TYPE_1:
                    var sphere1 = GameObject.Instantiate(_spherePrefabs[SPHERE_TYPE_1], transform);
                    sphere1.transform.position = position;
                    return new Sphere1Product(sphere1);
                case SPHERE_TYPE_2:
                    var sphere2 = GameObject.Instantiate(_spherePrefabs[SPHERE_TYPE_2], transform);
                    sphere2.transform.position = position;
                    return new Sphere2Product(sphere2);
            }
            return null;
        }




    }
}

