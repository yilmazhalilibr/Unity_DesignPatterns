using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class PooledObjectMover : MonoBehaviour
    {

        private void FixedUpdate()
        {
            gameObject.transform.Translate(0, 0, Time.deltaTime * 5f);
        }


    }
}

