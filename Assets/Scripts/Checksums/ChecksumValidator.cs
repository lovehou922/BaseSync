
using System.Collections.Generic;
/// <summary>
/// У�����֤��
/// </summary>
public interface ChecksumValidator
{
    //����֤
    bool IsValid(int frame, Checksum checksum, List<StoredChecksum> checksumList);
}
