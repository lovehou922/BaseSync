using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CommandProcessor
{
    /// <summary>
    /// 检查是否有需要处理的命令
    /// </summary>
    bool CheckReady(Commands commands, int frame);
    /// <summary>
    /// 处理每个单独的命令
    /// </summary>
    void Process(Command command, int frame);
}
