using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class ObserverManager : MonoBehaviour
    {
        Dictionary<ISubject, IObserver> _dict = new Dictionary<ISubject, IObserver>();
        List<ISubject> _subjects = new List<ISubject>();


        public void RegisterSubject(ISubject subject)
        {
            _subjects.Add(subject);

            //OnEnablaOnDisable..
        }
        public void UnregisterSubject(ISubject subject)
        {
            _subjects.Remove(subject);
            _dict.Remove(subject);
        }

        public void RegisterObserver(IObserver observer, NotificationType notificationType)
        {
            foreach (var i in _subjects)
            {
                if (i.Type == notificationType)
                {
                    _dict.TryAdd(i, observer);
                }
            }
        }
        public void UnregisterObserver(IObserver observer, NotificationType notificationType)
        {
            foreach (KeyValuePair<ISubject, IObserver> i in _dict)
            {
                if (i.Key.Type == notificationType && i.Value == observer)
                {
                    _dict.Remove(i.Key);
                }
            }
        }

        public void NotifyCall(ISubject subject, NotificationType notificationType)
        {
            foreach (var i in _dict)
            {
                if (i.Key == subject && notificationType == i.Key.Type)
                {
                    i.Value.Notified();
                }
            }
        }

    }

    public enum NotificationType
    {
        None,
        isHere
    }
}

