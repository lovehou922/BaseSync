using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 由想要与 GameState 协作的对象实现。(协作者)
/// </summary>
public interface GameStateCollaborator
{
    void SaveState(GameState gameState);
}
