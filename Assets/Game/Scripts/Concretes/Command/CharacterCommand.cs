using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class CharacterCommand : MonoBehaviour
    {
        [SerializeField] GameObject _body;

        public void OpenActive()
        {
            StartCoroutine(OnOpen());
        }

        public void StopActive()
        {
            StopCoroutine(OnOpen());
            _body.SetActive(true);
        }

        private IEnumerator OnOpen()
        {
            WaitForSeconds _sleep = new WaitForSeconds(0.5f);
            for (int i = 0; i < i + 2; i++)
            {
                yield return _sleep;
                _body.SetActive(i % 2 == 0);
            }
        }


    }
}

