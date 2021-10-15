
using System.Collections.Generic;
/// <summary>
/// 校验和验证器
/// </summary>
public interface ChecksumValidator
{
    //已验证
    bool IsValid(int frame, Checksum checksum, List<StoredChecksum> checksumList);
}
