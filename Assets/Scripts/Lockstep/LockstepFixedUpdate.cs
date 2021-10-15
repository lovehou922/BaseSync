using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockstepFixedUpdate : GameFixedUpdate, LockstepUpdate
{

    public readonly LockstepLogic _lockstepLogic;//֡ͬ���߼�����

    private int _currentLockstepFrame;//��ǰ�߼�֡
    private int _lastLockstepGameFrame;//��һ���߼�֡��

    public LockstepFixedUpdate(LockstepLogic lockstepLogic)
    {
        this._lockstepLogic = lockstepLogic;
    }
    //��Ϸ�߼�Ԥ��֡
    public int GameFramesPreviewLockstep
    {
        get;
        set;
    }
    public int CurrentLockstepFrame { get => _currentLockstepFrame; set => _currentLockstepFrame = value; }
    public int LastLockstepGameFrame { get => _lastLockstepGameFrame; private set => _lastLockstepGameFrame = value; }

    //���س�ʼ��
    public override void Init()
    {
        base.Init();
        _currentLockstepFrame = 0;
    }
    //����֡ͬ���̶�ˢ��
    public override void FixedTimeUpdate()
    {
        if(IsLockstepTurn())
        {
            //δ׼����
            if(!IsReady())
            {
                // ����
                return;
            }
            // Don't process same lockstep twice
            // ��Ҫ������ͬ����������
            ProcessLockstepLogic();
            _lastLockstepGameFrame = CurrentGameFrame;
            _currentLockstepFrame++;

        }
        // performs basic update logic...
        // ִ�л����ĸ����߼�...
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
        //��Ϊ��Ϸ֡������һ֮֡��(��ǰ����Ϸ֡��û�б�����)
        bool turn = ((CurrentGameFrame + 1) % GameFramesPreviewLockstep) == 0;
        return turn;
    }
    public bool IsReady()
    {
        // check for pending actions 
        // ������Ķ���
        return _lockstepLogic.IsReady(CurrentGameFrame);
    }
    //ִ����Ϸ�߼�֡���߼�
    void ProcessLockstepLogic()
    {
        // process pending actions..
        // �������Ķ���..
        _lockstepLogic.Process(CurrentGameFrame);
    }
    //��ȡ��һ֡
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
