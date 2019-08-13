using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    INIT,
    RUNNING,
    WON,
    LOST,
    NONE
}

public class Globals : MonoBehaviour
{
    public static GameState gameState;

    void Start()
    {
        Debug.Log("new start");
        gameState = GameState.INIT;
    }

    private void Update()
    {
        
    }


}
