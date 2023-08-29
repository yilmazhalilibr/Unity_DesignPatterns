using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using UnityEngine;

namespace Unity_DesignPatterns.Concretes
{
    public class SetActiveWithCommand : ICommand
    {
        CharacterCommand _command;
        public SetActiveWithCommand(CharacterCommand characterCommand)
        {
            _command = characterCommand;
        }

        public void Execute()
        {
            _command.OpenActive();
        }

        public void Undo()
        {
            _command.StopActive();
        }


    }
}

