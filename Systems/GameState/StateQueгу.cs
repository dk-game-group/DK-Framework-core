using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateQurie 
{
    Queue<GameState> mainQueue;
    Queue<GameState> secondaryQueue;

    public int mainQueueLength { get; private set; } = 10;
}
