using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 指令记录列表
/// </summary>
public class CommandsRecorder
{
	readonly List<RecordedCommand> recordedCommandsQueue = new List<RecordedCommand>();

	public void AddCommand(int gameFrame, Command command)
	{
		recordedCommandsQueue.Add(new RecordedCommand()
		{
			command = command,
			gameFrame = gameFrame
		});
	}

	public void GetCommandsForFrame(int frame, List<Command> commands)
	{
		for (int i = 0; i < recordedCommandsQueue.Count; i++)
		{
			var recordedCommand = recordedCommandsQueue[i];
			if (recordedCommand.gameFrame == frame)
				commands.Add(recordedCommand.command);
		}
	}
}