using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEventListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNextLevelButtonClick()
    {
        //Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        //Globals.gameState = GameState.INIT;
        //SceneManager.UnloadSceneAsync(activeScene);
    }

    public void OnRetryButtonClick()
    {
        //Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        //SceneManager.UnloadSceneAsync(activeScene);
        //Globals.gameState = GameState.INIT;
    }

}
