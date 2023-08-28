using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class ObserverTester : MonoBehaviour, IObserver
    {
        [SerializeField] ObserverManager _observerManager;

        private void Start()
        {
            _observerManager.RegisterObserver(this, NotificationType.isHere);
        }
        public void Notified()
        {
            Debug.Log("Observer :Red is next to me");
        }
    }
}

