using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class SubjectTester : MonoBehaviour, ISubject
    {
        [SerializeField] ObserverManager _observerManager;
        [SerializeField] NotificationType _notificationType;
        public NotificationType Type => _notificationType;
        private void Awake()
        {
        }
        private void Start()
        {
        }
        private void OnEnable()
        {
            _observerManager.RegisterSubject(this);
            StartCoroutine(Notifier());
        }
        private void OnDisable()
        {
            _observerManager.UnregisterSubject(this);
            StopCoroutine(Notifier());
        }
        public void OnNotify()
        {
            _observerManager.NotifyCall(this, Type);
        }

        IEnumerator Notifier()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                OnNotify();
            }
        }

    }
}
