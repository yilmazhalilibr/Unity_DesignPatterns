using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Concretes;
using UnityEngine;

namespace Unity_DesignPatterns.Abstracts
{
    public interface IObserver
    {
        NotificationType NotificationType { get; }
        void Notified();
    }
}

