using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 校验和记录器
/// </summary>
public class ChecksumRecorder
{
    //校验提供
    readonly ChecksumProvider _checksumProvider;
    //
    readonly List<StoredChecksum> _storedChecksums = new List<StoredChecksum>();

    public ChecksumProvider ChecksumProvider => _checksumProvider;

    public List<StoredChecksum> StoredChecksums => _storedChecksums;

    public ChecksumRecorder(ChecksumProvider checksumProvider)
    {
        _checksumProvider = checksumProvider;
    }
    //重置
    public void Reset()
    {
        _storedChecksums.Clear();
    }
    //记录状态(帧)
    public void RecordState(int frame)
    {
        _storedChecksums.Add(new StoredChecksum()
        {
            gameFrame = frame,
            checksum = _checksumProvider.CalculateChecksum(),
        });
    }
}
