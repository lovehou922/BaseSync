using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �ṩһ���ɾ��� GameState ʵ����
/// </summary>
public interface GameStateProvider
{
    GameState GetGameState();
}