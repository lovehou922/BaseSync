
public interface LockstepUpdate
{
	bool IsLastFrameForNextLockstep();

	/// <summary>
	/// ��ȡ��һ֡
	/// </summary>
	int GetNextLockstepFrame();
	/// <summary>
	/// ��ȡ��ǰ֡
	/// </summary>
	int GetCurrentFrame();
}
