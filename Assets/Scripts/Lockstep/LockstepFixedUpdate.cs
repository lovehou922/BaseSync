using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockstepFixedUpdate : GameFixedUpdate, LockstepUpdate
{

    public readonly LockstepLogic _lockstepLogic;//帧同步逻辑对象

    private int _currentLockstepFrame;//当前逻辑帧
    private int _lastLockstepGameFrame;//上一个逻辑帧数

    public LockstepFixedUpdate(LockstepLogic lockstepLogic)
    {
        this._lockstepLogic = lockstepLogic;
    }
    //游戏逻辑预测帧
    public int GameFramesPreviewLockstep
    {
        get;
        set;
    }
    public int CurrentLockstepFrame { get => _currentLockstepFrame; set => _currentLockstepFrame = value; }
    public int LastLockstepGameFrame { get => _lastLockstepGameFrame; private set => _lastLockstepGameFrame = value; }

    //重载初始化
    public override void Init()
    {
        base.Init();
        _currentLockstepFrame = 0;
    }
    //重载帧同步固定刷新
    public override void FixedTimeUpdate()
    {
        if(IsLockstepTurn())
        {
            //未准备好
            if(!IsReady())
            {
                // 跳过
                return;
            }
            // Don't process same lockstep twice
            // 不要处理相同的锁步两次
            ProcessLockstepLogic();
            _lastLockstepGameFrame = CurrentGameFrame;
            _currentLockstepFrame++;

        }
        // performs basic update logic...
        // 执行基本的更新逻辑...
        base.FixedTimeUpdate();
    }
    public bool IsLockstepTurn()
    {
        if(CurrentGameFrame == 0)
        {
            return false;
        }
        //
        if (CurrentGameFrame == LastLockstepGameFrame)
        {
            return false;
        }
        //since the game frame is always behind one frame(current game frame wasnt processed yet)
        //因为游戏帧总是在一帧之后(当前的游戏帧还没有被处理)
        bool turn = ((CurrentGameFrame + 1) % GameFramesPreviewLockstep) == 0;
        return turn;
    }
    public bool IsReady()
    {
        // check for pending actions 
        // 检查挂起的动作
        return _lockstepLogic.IsReady(CurrentGameFrame);
    }
    //执行游戏逻辑帧，逻辑
    void ProcessLockstepLogic()
    {
        // process pending actions..
        // 处理挂起的动作..
        _lockstepLogic.Process(CurrentGameFrame);
    }
    //获取第一帧
    public int GetFirstLockstepFrame()
    {
        return GameFramesPreviewLockstep - 1;
    }

    public int GetCurrentFrame()
    {
        return CurrentGameFrame;
    }
    public int GetNextLockstepFrame()
    {
        return GetNextLockstepFrame(CurrentGameFrame);
    }
    public int GetNextLockstepFrame(int currentFrame)
    {
        /*
        int iFrame = (currentFrame / 2) + 2;
        int nextFrame = (2 * iFrame) - 1;
        return nextFrame;
        */
        int iFrame = (currentFrame / GameFramesPreviewLockstep) + 2;
        int nextFrame = (GameFramesPreviewLockstep * iFrame) - 1;
        return nextFrame;
    }
    public bool IsLastFrameForNextLockstep(int frame)
    {
        return GetNextLockstepFrame(frame) != GetNextLockstepFrame(frame + 1);
    }
    public bool IsLastFrameForNextLockstep()
    {
        return IsLastFrameForNextLockstep(CurrentGameFrame);
    }



}
