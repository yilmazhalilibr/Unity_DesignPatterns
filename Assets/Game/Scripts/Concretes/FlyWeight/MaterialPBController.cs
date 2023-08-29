using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class MaterialPBController : MonoBehaviour
    {
        [SerializeField] Color _mainColor = Color.black;

        private Renderer _renderer = null;

        private MaterialPropertyBlock _materialPropertyBlock = null;

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _materialPropertyBlock = new MaterialPropertyBlock();
        }
        private void Update()
        {
            _materialPropertyBlock.SetColor("_Color",_mainColor);
            _renderer.SetPropertyBlock(_materialPropertyBlock);
        }
    }
}

