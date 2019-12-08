using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour {

    public static bool paused = false;
    public GameObject pausemenuui;
    public GameObject w;
    public AudioMixer audiomixer;
    public float resetvol = 0;
   
 

    // Use this for initialization
    void Start () {	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
   
                Resume();

            }
            else
            {
               

          
    

                Pause();
            }
        }
	}

    public void Resume()
    {
        pausemenuui.SetActive(false);
        if (!PlayerMovement.env_scroll)
        {
            w.SetActive(true);
        }
        Time.timeScale = 1.0f;
        paused = false;
        audiomixer.SetFloat("sfxVolume", resetvol);
    }

    public void Pause()
    {
        pausemenuui.SetActive(true);
        w.SetActive(false);
        Time.timeScale = 0f;
        paused = true;

        audiomixer.GetFloat("sfxVolume", out resetvol);
        audiomixer.SetFloat("sfxVolume", -60f);
    }

    public void Menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
        
        
    }
    public void Quit()
    {
        Debug.Log("Quittingggggggg...........");
        Application.Quit();
    }
}
