using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Unity_DesignPatterns.Abstracts
{
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : Component
    {
        public static T Instance;

        protected void SetSingleton(T instance)
        {
            if (Instance != null)
            {
                Instance = instance;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}

