using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class ObserverTester : MonoBehaviour, IObserver
    {
        [SerializeField] ObserverManager _observerManager;
        [SerializeField] NotificationType _notificationType;

        public NotificationType NotificationType => _notificationType;
        private void Start()
        {
            _observerManager.RegisterObserver(this, _notificationType);
        }
        public void Notified()
        {
            Debug.Log("Observer :Red is next to me");
        }
    }
}

