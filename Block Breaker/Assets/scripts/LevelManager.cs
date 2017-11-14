using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevel(string levelName)
    {
        print("Loading level" + levelName);

        //loads the scene name level 
        SceneManager.LoadScene(levelName);
    }

    public void exit()
    {
        print("Exiting level");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
