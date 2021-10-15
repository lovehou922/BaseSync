using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFixedUpdate
{
    private int _currentGameFrame;      //当前帧数

    //固定更新帧时间
    private float _fixedStepTime = 0.05f;//50ms 更新一帧，1秒20帧
    private float _accumulatedTime;//累计时间
    private float _gameTime;//游戏时间

    // fixed time step based on http://gafferongames.com/game-physics/fix-your-timestep/
    private float maxAllowedFrameTime = 0.25f;//最大允许的帧时间


    private GameLogic _gameLogic;//逻辑对象

    public float FixedStepTime { get => _fixedStepTime; set => _fixedStepTime = value; }
    public float AccumulatedTime { get => _accumulatedTime; private set => _accumulatedTime = value; }
    public float GameTime { get => _gameTime; set => _gameTime = value; }
    public int CurrentGameFrame { get => _currentGameFrame; set => _currentGameFrame = value; }
    public GameLogic GameLogic { get => _gameLogic; set => _gameLogic = value; }
    public float MaxAllowedFrameTime { get => maxAllowedFrameTime; set => maxAllowedFrameTime = value; }

    public virtual void Init()
    {
        _currentGameFrame = 0;
        _accumulatedTime = 0;
        _gameTime = 0;
    }

    public virtual void Update(float fixedStepTime)
    {
        if(fixedStepTime > maxAllowedFrameTime)
        {
            fixedStepTime = maxAllowedFrameTime;
        }
        //记录累计时间
        _accumulatedTime += fixedStepTime;
        while(_accumulatedTime >= _fixedStepTime)
        {
            FixedTimeUpdate();
            //重置累计时间
            _accumulatedTime -= _fixedStepTime;
        }
    }

    public virtual void FixedTimeUpdate()
    {
        if(_gameLogic !=null)
        {
            _gameLogic.GameUpdate(_fixedStepTime, _currentGameFrame);
        }
        _gameTime += _fixedStepTime;
        _currentGameFrame++;
    }
}
