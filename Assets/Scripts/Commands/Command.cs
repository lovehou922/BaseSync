using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ָ��ӿ�
/// </summary>
public interface Command
{
    /// <summary>
    /// ��Ӧ�ô�������ʱ����lockstep֡��
    /// </summary>
    int ProcessFrame
    {
        get;
        set;
    }
}
