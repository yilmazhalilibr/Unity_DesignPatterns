using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Concretes;
using UnityEngine;

public class CommandTester : MonoBehaviour
{
    CharacterCommand _character;
    CommandInvorker _invorker;
    SetActiveWithCommand _setActiveComd;
    private void Awake()
    {
        _character = GetComponent<CharacterCommand>();
        _invorker = new CommandInvorker();
        _setActiveComd = new SetActiveWithCommand(_character);
    }
    private void Start()
    {
        _invorker.SetCommand(_setActiveComd);
        _invorker.ExecuteCommand();

    }

  

}
