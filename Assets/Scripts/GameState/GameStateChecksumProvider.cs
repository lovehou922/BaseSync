using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��Ϸ״̬У����ṩ����
/// </summary>
public class GameStateChecksumProvider : ChecksumProvider
{
    readonly GameStateProvider _gameStateProvider;

    public GameStateChecksumProvider(GameStateProvider gameStateProvider)
    {
        _gameStateProvider = gameStateProvider;
    }
    public Checksum CalculateChecksum()
    {
        var gameState = _gameStateProvider.GetGameState();
        return gameState.CalculateChecksum();
    }
}
