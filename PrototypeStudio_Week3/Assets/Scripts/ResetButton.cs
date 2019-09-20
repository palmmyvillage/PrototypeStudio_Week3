using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{

    public KeyCode resetGameButton, resetSceneButton, quitGameButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetGame();
        ResetScene();
        QuitGame();
    }

    void ResetGame()
    {
        if (Input.GetKeyDown(resetGameButton))
            SceneManager.LoadScene(0);
    }

    void ResetScene()
    {
        if (Input.GetKeyDown(resetSceneButton))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void QuitGame()
    {
        if (Input.GetKeyDown(quitGameButton))
            Application.Quit();
    }
}
