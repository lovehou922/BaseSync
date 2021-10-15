/// <summary>
/// 校验接口
/// </summary>

// a single checksum for the game state
// 游戏状态的单个校验和
public interface Checksum
{
    // true if both checksum are equals
    // 如果两个校验和相等则为真
    public bool IsEqual(Checksum checksum);
}
