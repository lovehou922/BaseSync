public interface LockstepLogic
{
	/// <summary>
	/// �Ƿ��Ѿ�׼��
	/// </summary>
	bool IsReady(int frame);
	
	/// <summary>
	/// ִ��֡
	/// </summary>
	void Process(int frame);
}

