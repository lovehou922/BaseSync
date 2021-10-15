
public interface LockstepUpdate
{
	bool IsLastFrameForNextLockstep();

	/// <summary>
	/// 获取下一帧
	/// </summary>
	int GetNextLockstepFrame();
	/// <summary>
	/// 获取当前帧
	/// </summary>
	int GetCurrentFrame();
}
