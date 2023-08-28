using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Abstracts
{
    public interface IProduct
    {
        GameObject ProductGameObject { get; }
        string ProductName { get; }
    }
}

