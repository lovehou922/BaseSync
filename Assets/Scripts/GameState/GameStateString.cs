using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
/// <summary>
/// 这只是主要用于调试和测试的 GameState 的基本实现，而不是真正要使用的实现。
/// </summary>
public class GameStateString : GameState
{
    StringBuilder state = new StringBuilder();

    public string State {
        get {
            return state.ToString();
        } 
    }
    public Checksum CalculateChecksum()
    {
        return new ChecksumString(ChecksumHelper.CalculateMD5(State));
    }

    bool firstObject = true;
    bool firstElement = true;

    public void StartObject(string name)
    {
        firstElement = true;
        state.AppendFormat("{1}{0}:(", name, firstObject ? "" : ",");
    }
    public void EndObject()
    {
        state.Append(")");
        firstObject = false;
    }
    public void SetInt(string name,int i)
    {
        state.AppendFormat("{2}{0}:{1}", name, i, firstElement ? "" : ",");
        firstElement = false;
    }
    public void SetFloat(string name, float f)
    {
        state.AppendFormat("{2}{0}:{1}", name, f, firstElement ? "" : ",");
        firstElement = false;
    }
    public void SetBool(string name, bool b)
    {
        state.AppendFormat("{2}{0}:{1}", name, b, firstElement ? "" : ",");
        firstElement = false;
    }
    public void Reset()
    {
        state = new StringBuilder();
        firstObject = true;
        firstElement = true;
    }
}
