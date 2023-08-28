using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Abstracts
{
    public abstract class BaseFactory : MonoBehaviour
    {
        public abstract int Count { get; }
        public abstract IProduct GetProduct(int productType, Vector3 position);
    }
}

