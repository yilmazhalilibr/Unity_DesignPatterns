using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Concretes;
using UnityEngine;

namespace Unity_DesignPatterns.Abstracts
{
    public interface ISubject
    {
        NotificationType Type { get; }
        void OnNotify();

    }
}

