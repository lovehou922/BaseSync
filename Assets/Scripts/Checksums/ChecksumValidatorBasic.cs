using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 验证器的基础类型
/// </summary>
public class ChecksumValidatorBasic : ChecksumValidator
{
    public bool IsValid(int frame, Checksum checksum, List<StoredChecksum> checksumList)
    {
        for(int i = 0; i<checksumList.Count;i++)
        {
            var checksumTemp = checksumList[i];
            //通过帧对比，在验证这一帧的状态
            if (checksumTemp.gameFrame == frame)
            {
                return checksumTemp.checksum.IsEqual(checksum);
            }
        }

        // 如果没有要验证的存储校验和，则当前帧校验和有效
        return true;
    }
}
