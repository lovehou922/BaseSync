/// <summary>
/// У��ӿ�
/// </summary>

// a single checksum for the game state
// ��Ϸ״̬�ĵ���У���
public interface Checksum
{
    // true if both checksum are equals
    // �������У��������Ϊ��
    public bool IsEqual(Checksum checksum);
}
