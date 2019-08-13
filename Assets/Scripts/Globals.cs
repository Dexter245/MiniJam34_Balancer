using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    INIT,
    RUNNING,
    WON,
    LOST
}

public static class Globals
{

    public static GameState gameState = GameState.INIT;
}
