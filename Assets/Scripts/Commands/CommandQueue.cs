using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 指令队列
/// </summary>
public interface CommandQueue
{
	/// <summary>
	/// 添加指令
	/// </summary>
	void EnqueueCommand(Command command);

	bool IsReady();

	void SendCommands();
}
