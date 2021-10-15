using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 指令发送器
/// </summary>
public interface CommandSender
{
    /// <summary>
    /// 发送空指令
    /// </summary>
    void SendEmpty();
    /// <summary>
    /// 发送指令列表
    /// </summary>
    void SendCommands(List<Command> commands);
    /// <summary>
    /// 保存指令
    /// </summary>
    void SaveCommand(List<Command> commands);
}

