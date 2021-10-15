using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 提供一个干净的 GameState 实例。
/// </summary>
public interface GameStateProvider
{
    GameState GetGameState();
}