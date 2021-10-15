public interface LockstepLogic
{
	/// <summary>
	/// 是否已经准备
	/// </summary>
	bool IsReady(int frame);
	
	/// <summary>
	/// 执行帧
	/// </summary>
	void Process(int frame);
}

