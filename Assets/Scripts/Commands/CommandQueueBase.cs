using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������ְ���ǽ��������Ӳ��ڴˣ�֡������ʱ�����Ƿ��͵�����
/// ��ǰ����֡������һ������֡�������û������
/// ���(Enqueue)��������һ����������������Ϸ����������
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
