using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 指令接口
/// </summary>
public interface Command
{
    /// <summary>
    /// 在应该处理命令时返回lockstep帧。
    /// </summary>
    int ProcessFrame
    {
        get;
        set;
    }
}
