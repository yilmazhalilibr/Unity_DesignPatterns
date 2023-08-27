using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class SingletonObject : SingletonMonoBehaviour<SingletonObject>
    {
        private WaitForSeconds _wait = new WaitForSeconds(1f);

        private void Start()
        {
            StartCoroutine(ObjectCall());
        }

        private IEnumerator ObjectCall()
        {
            while (true)
            {
                yield return _wait;
                Debug.Log("Singleton Object is LIVE!");
            }

        }
    }
}
