using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);//Loads next scene
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);//Loads start screen
    }

    public void QuitGame()
    {
        Application.Quit();//Quits game
    }
}
