using System.Collections;
using System.Collections.Generic;
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
            StartCoroutine(Notifier());
        }
        private void OnEnable()
        {
            _observerManager.RegisterSubject(this);
        }
        private void OnDisable()
        {
            _observerManager.UnregisterSubject(this);
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
