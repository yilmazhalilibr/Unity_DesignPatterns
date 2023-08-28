using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public interface ISubject
    {
        NotificationType Type { get; }
        void OnNotify();

    }
}

