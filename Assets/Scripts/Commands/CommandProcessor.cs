using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CommandProcessor
{
    /// <summary>
    /// ����Ƿ�����Ҫ���������
    /// </summary>
    bool CheckReady(Commands commands, int frame);
    /// <summary>
    /// ����ÿ������������
    /// </summary>
    void Process(Command command, int frame);
}
