using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ָ�����
/// </summary>
public interface CommandQueue
{
	/// <summary>
	/// ���ָ��
	/// </summary>
	void EnqueueCommand(Command command);

	bool IsReady();

	void SendCommands();
}
