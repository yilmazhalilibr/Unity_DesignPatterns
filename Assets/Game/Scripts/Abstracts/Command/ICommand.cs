using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity_DesignPatterns.Abstracts
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}