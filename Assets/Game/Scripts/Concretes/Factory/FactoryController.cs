using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class FactoryController : MonoBehaviour
    {
        CapsuleFactory _capsuleFactory;
        SphereFactory _sphereFactory;
        CubeFactory _cubeFactory;

        WaitForSeconds _sleep = new WaitForSeconds(2f);

        List<BaseFactory> _factories = new List<BaseFactory>();

        GameObject _tempInstantie;
        private void Awake()
        {
            _capsuleFactory = GetComponentInChildren<CapsuleFactory>();
            _sphereFactory = GetComponentInChildren<SphereFactory>();
            _cubeFactory = GetComponentInChildren<CubeFactory>();

            _factories.Add(_capsuleFactory);
            _factories.Add(_sphereFactory);
            _factories.Add(_cubeFactory);
        }
        private void Start()
        {
            StartCoroutine(FactoriesHandle());
        }

        private IEnumerator FactoriesHandle()
        {

            while (true)
            {
                for (int i = 0; i < _factories.Count; i++)
                {
                    for (int k = 0; k < _factories[i].Count; k++)
                    {
                        yield return _sleep;
                        if (_tempInstantie != null) Destroy(_tempInstantie.gameObject);
                        var product = _factories[i].GetProduct(k, transform.position);
                        _tempInstantie = product.ProductGameObject;
                        Debug.Log("Product Name: " + product.ProductName);
                    }
                }
            }
        }



    }


}

