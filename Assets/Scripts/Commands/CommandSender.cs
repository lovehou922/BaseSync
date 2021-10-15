using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ָ�����
/// </summary>
public interface CommandSender
{
    /// <summary>
    /// ���Ϳ�ָ��
    /// </summary>
    void SendEmpty();
    /// <summary>
    /// ����ָ���б�
    /// </summary>
    void SendCommands(List<Command> commands);
    /// <summary>
    /// ����ָ��
    /// </summary>
    void SaveCommand(List<Command> commands);
}

