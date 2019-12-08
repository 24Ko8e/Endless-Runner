using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool gameEND;
    float restartdelay = 1.0f;

    public void endgame()
    {
        if(gameEND == false)
        gameEND = true;
        Invoke("restart", restartdelay); ;
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	// Use this for initialization
	void Start () {
        gameEND = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
