using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class CapsuleFactory : BaseFactory
    {
        [SerializeField] List<GameObject> _capsulePrefabs = new List<GameObject>();

        public const int TYPE_CAPSULE_1 = 0;

        public override int Count => _capsulePrefabs.Count;

        public override IProduct GetProduct(int productType, Vector3 position)
        {
            switch (productType)
            {
                case TYPE_CAPSULE_1:
                    var capsule = GameObject.Instantiate(_capsulePrefabs[TYPE_CAPSULE_1], transform);
                    capsule.transform.position = position;
                    return new Capsule1Product(capsule);
            }
            return null;
        }



    }
}

