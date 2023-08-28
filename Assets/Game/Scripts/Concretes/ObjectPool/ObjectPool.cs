using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class ObjectPool
    {
        private Queue<GameObject> _pooledObjects = new Queue<GameObject>();
        private GameObject _objectPrefab;
        private int _objectCount;
        private MonoBehaviour _class;

        public ObjectPool(MonoBehaviour GetClass, GameObject GameObjectPrefab, int objectCount)
        {
            _objectPrefab = GameObjectPrefab;
            _objectCount = objectCount;
            _class = GetClass;

            InitializePool();
        }

        private void InitializePool()
        {
            for (int i = 0; i < _objectCount; i++)
            {
                var obj = GameObject.Instantiate(_objectPrefab, _class.transform);
                obj.SetActive(false);
                _pooledObjects.Enqueue(obj);
            }
        }

        public GameObject GetPoolObject()
        {
            GameObject obj = _pooledObjects.Dequeue();
            obj.SetActive(true);
            _pooledObjects.Enqueue(obj);
            return obj;
        }



    }
}

