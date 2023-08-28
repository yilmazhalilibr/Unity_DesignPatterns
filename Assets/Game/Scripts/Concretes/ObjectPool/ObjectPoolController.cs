using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class ObjectPoolController : MonoBehaviour
    {
        [SerializeField] GameObject _objectPrefab;
        [SerializeField] int _count;
        [SerializeField] Transform _position;
        ObjectPool _pool;
        WaitForSeconds _sleep = new WaitForSeconds(1);

        private void Awake()
        {
            _pool = new ObjectPool(this, _objectPrefab, _count);
        }
        private void Start()
        {
            StartCoroutine(PoolHandle());
        }

        IEnumerator PoolHandle()
        {
            while (true)
            {
                yield return _sleep;
                var obj = _pool.GetPoolObject();
                obj.transform.position = _position.position;
            }

        }



    }
}

