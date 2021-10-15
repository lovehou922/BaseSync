using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ַ��������У��
/// </summary>
public class ChecksumString : Checksum
{
    string _checksum;

    public string Checksum { get => _checksum; private set => _checksum = value; }

    public ChecksumString(string checksum)
    {
        _checksum = checksum;
    }

    public bool IsEqual(Checksum checksum)
    {
        if(checksum == this)
        {
            return true;
        }
        ChecksumString otherChecksum = checksum as ChecksumString;
        if(otherChecksum == null)
        {
            return false;
        }
        return otherChecksum._checksum.Equals(this._checksum);
    }
}