using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandsList : Commands
{
    readonly List<Command> _commands = new List<Command>();
    readonly List<Command> _tempRemoveCommands = new List<Command>();

    public List<Command> Commands => _commands;

    public void AddCommand(Command command)
    {
        _commands.Add(command);
    }

    public void GetCommands(List<Command> commands)
    {
        for (int i = 0; i < _commands.Count; i++)
        {
            commands.Add(_commands[i]);
        }
    }

    public void GetCommands(int frame, List<Command> commands)
    {
        for (int i = 0; i < _commands.Count; i++)
        {
            if (_commands[i].ProcessFrame == frame)
            {
                commands.Add(_commands[i]);
            }
        }
    }

    public bool HasCommand(int frame)
    {
        for (int i = 0; i < _commands.Count; i++)
        {
            if (_commands[i].ProcessFrame == frame)
            {
                return true;
            }
        }
        return false;
    }

    public void RemoveCommands(int frame)
    {
        for (int i = 0; i < _commands.Count; i++)
        {
            var tempCommand = _commands[i];

            if (tempCommand.ProcessFrame == frame)
            {
                _tempRemoveCommands.Add(tempCommand);
            }
        }
        for (int i = 0; i < _tempRemoveCommands.Count; i++)
        {
            var removeCommand = _tempRemoveCommands[i];
            _commands.Remove(removeCommand);
        }
        _tempRemoveCommands.Clear();
    }
}
