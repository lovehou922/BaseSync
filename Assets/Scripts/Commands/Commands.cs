using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ָ���б�
/// </summary>
public interface Commands
{
    /// <summary>
    /// ���ָ��
    /// </summary>
    void AddCommand(Command command);
    /// <summary>
    /// �Ƿ���ĳһ֡��ָ��
    /// </summary>
    bool HasCommand(int frame);
    /// <summary>
    /// ��ȡָ���б�
    /// </summary>
    void GetCommands(List<Command> commands);
    /// <summary>
    /// ��ȡĳһ֡��ָ���б�
    /// </summary>
    void GetCommands(int frame, List<Command> commands);
    /// <summary>
    /// �Ƴ�ָ��֡��ָ��
    /// </summary>
    void RemoveCommands(int frame);
}
