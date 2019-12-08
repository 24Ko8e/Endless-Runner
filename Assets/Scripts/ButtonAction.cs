using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour {



public void playgame()
    {
        SceneManager.LoadScene("GameScene1");
       
    }

public void quitgame()
    {
        Application.Quit();

    }
}
