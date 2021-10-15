using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 这个类的职责是将命令加入队并在此（帧）结束时将它们发送到处理
/// 当前锁步帧，在下一个锁步帧处理。如果没有命令
/// 入队(Enqueue)，它发送一个空命令来保持游戏锁步工作。
/// </summary>
public class CommandQueueBase : CommandQueue
{
    readonly LockstepUpdate _lockstepUpdate;
    readonly CommandSender _commandSender;
    readonly List<Command> _queuedCommands = new List<Command>();

    public CommandQueueBase(LockstepUpdate lockstepUpdate,CommandSender commandSender)
    {
        _lockstepUpdate = lockstepUpdate;
        _commandSender = commandSender;
    }

    public void EnqueueCommand(Command command)
    {
    }

    public bool IsReady()
    {
        return _lockstepUpdate.IsLastFrameForNextLockstep();
    }

    public void SendCommands()
    {
        if(_queuedCommands.Count == 0)
        {
            _commandSender.SendEmpty();
        }
        else
        {
            _commandSender.SendCommands(_queuedCommands);
            _queuedCommands.Clear();
        }
    }
}
