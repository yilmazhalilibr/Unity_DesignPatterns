using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Unity_DesignPatterns.Concretes
{
    public class MVPPresenter : MonoBehaviour
    {
        [SerializeField] GameObject _body;
        MVPModel _model;

        private void Awake()
        {
            _model = new MVPModel();
        }
        private void Start()
        {
            _body.GetComponent<MeshRenderer>().material.color = _model.Color;
        }
        private void OnEnable()
        {
            StartCoroutine(DataHandle());
        }
        private void OnDisable()
        {
            StopCoroutine(DataHandle());
        }
        IEnumerator DataHandle()
        {
            WaitForSeconds _wait = new WaitForSeconds(1f);
            while (true)
            {
                yield return _wait;

                //MVP View 
                Debug.Log(_model.Data);

            }
        }



    }
}

