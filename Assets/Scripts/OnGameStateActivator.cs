using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGameStateActivator : MonoBehaviour
{
    private Dictionary<GameState, List<GameObject>> activate = new Dictionary<GameState, List<GameObject>>();
    private Dictionary<GameState, List<GameObject>> deactivate = new Dictionary<GameState, List<GameObject>>();
    private GameState lastGameState = GameState.NONE;

    // Start is called before the first frame update
    void Start()
    {
        AddListsForAllGameStates(activate);
        AddListsForAllGameStates(deactivate);

        ActivateOnGameState[] objs = Resources.FindObjectsOfTypeAll<ActivateOnGameState>();
        foreach(ActivateOnGameState obj in objs)
        {
            activate[obj.gameState].Add(obj.gameObject);
        }
        DeactivateOnGameState[] objs2 = Resources.FindObjectsOfTypeAll<DeactivateOnGameState>();
        foreach(DeactivateOnGameState obj in objs2)
        {
            deactivate[obj.gameState].Add(obj.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Globals.gameState != lastGameState)
        {
            lastGameState = Globals.gameState;

            foreach(GameObject obj in activate[Globals.gameState])
            {
                obj.SetActive(true);
            }
            foreach(GameObject obj in deactivate[Globals.gameState])
            {
                obj.SetActive(false);
            }

        }
    }

    private void AddListsForAllGameStates(Dictionary<GameState, List<GameObject>> dict)
    {
        dict.Add(GameState.INIT, new List<GameObject>());
        dict.Add(GameState.RUNNING, new List<GameObject>());
        dict.Add(GameState.WON, new List<GameObject>());
        dict.Add(GameState.LOST, new List<GameObject>());
    }

}
