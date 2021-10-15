using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 指令列表
/// </summary>
public interface Commands
{
    /// <summary>
    /// 添加指令
    /// </summary>
    void AddCommand(Command command);
    /// <summary>
    /// 是否有某一帧的指令
    /// </summary>
    bool HasCommand(int frame);
    /// <summary>
    /// 获取指令列表
    /// </summary>
    void GetCommands(List<Command> commands);
    /// <summary>
    /// 获取某一帧的指令列表
    /// </summary>
    void GetCommands(int frame, List<Command> commands);
    /// <summary>
    /// 移除指定帧的指令
    /// </summary>
    void RemoveCommands(int frame);
}
