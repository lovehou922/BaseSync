using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����Ҫ�� GameState Э���Ķ���ʵ�֡�(Э����)
/// </summary>
public interface GameStateCollaborator
{
    void SaveState(GameState gameState);
}
