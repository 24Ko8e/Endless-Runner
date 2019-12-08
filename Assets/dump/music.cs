using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class music : MonoBehaviour {

    public AudioSource[] musicfiles;
    public AudioMixer audiomixer;

	// Use this for initialization
	void Awake () {
        for (int i = 0; i < musicfiles.Length; i++)
        {

            if (i == 0)
            {
                musicfiles[i].PlayScheduled(AudioSettings.dspTime + 0);
            }
            if (i == 1)
            {
                musicfiles[i].PlayScheduled(AudioSettings.dspTime + 240);
            }
            if (i == 2)
            {
                musicfiles[i].PlayScheduled(AudioSettings.dspTime + 500);
            }
            if (i == 3)
            {
                musicfiles[i].PlayScheduled(AudioSettings.dspTime + 720);
            }
            if (i == 4)
            {
                musicfiles[i].PlayScheduled(AudioSettings.dspTime + 940);
            }
            if (i == 5)
            {
                musicfiles[i].PlayScheduled(AudioSettings.dspTime + 1120);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (PauseMenu.paused)
        {
            audiomixer.SetFloat("musicVolume", -60f);
        }
        else
        {
            audiomixer.SetFloat("musicVolume", 0f);
        }
    }

}
