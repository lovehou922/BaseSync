using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��֤���Ļ�������
/// </summary>
public class ChecksumValidatorBasic : ChecksumValidator
{
    public bool IsValid(int frame, Checksum checksum, List<StoredChecksum> checksumList)
    {
        for(int i = 0; i<checksumList.Count;i++)
        {
            var checksumTemp = checksumList[i];
            //ͨ��֡�Աȣ�����֤��һ֡��״̬
            if (checksumTemp.gameFrame == frame)
            {
                return checksumTemp.checksum.IsEqual(checksum);
            }
        }

        // ���û��Ҫ��֤�Ĵ洢У��ͣ���ǰ֡У�����Ч
        return true;
    }
}
