using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterGameRuns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.gameState == GameState.RUNNING)
        {
            gameObject.SetActive(false);
            enabled = false;
        }
    }
}
