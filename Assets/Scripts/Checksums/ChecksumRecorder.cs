using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// У��ͼ�¼��
/// </summary>
public class ChecksumRecorder
{
    //У���ṩ
    readonly ChecksumProvider _checksumProvider;
    //
    readonly List<StoredChecksum> _storedChecksums = new List<StoredChecksum>();

    public ChecksumProvider ChecksumProvider => _checksumProvider;

    public List<StoredChecksum> StoredChecksums => _storedChecksums;

    public ChecksumRecorder(ChecksumProvider checksumProvider)
    {
        _checksumProvider = checksumProvider;
    }
    //����
    public void Reset()
    {
        _storedChecksums.Clear();
    }
    //��¼״̬(֡)
    public void RecordState(int frame)
    {
        _storedChecksums.Add(new StoredChecksum()
        {
            gameFrame = frame,
            checksum = _checksumProvider.CalculateChecksum(),
        });
    }
}
