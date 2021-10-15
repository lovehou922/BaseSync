using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandBase :Command
{
    public int processFrame;
    public int ProcessFrame {
        get
        {
            return processFrame;
        }
        set
        {
            processFrame = value;
        }
    }

}
