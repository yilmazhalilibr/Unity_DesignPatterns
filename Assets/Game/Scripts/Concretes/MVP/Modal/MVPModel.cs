using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class MVPModel
    {
        string _data = "MVP :I'm MVP Data!";
        Color _color = Color.yellow;
        public string Data { get => _data; }
        public Color Color { get => _color; }
    }
}

