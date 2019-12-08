using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour {

    public AudioMixer audiomixer;

    public Slider sfxslider;

    public void setsfxvolume(float svolume)
    {
        audiomixer.SetFloat("sfxVolume", svolume);
    }

    

	// Use this for initialization
	void Start () {

        sfxslider.value = PlayerPrefs.GetFloat("sfxVolume");
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnDisable()
    {
        float sfxvolume = 0;

        audiomixer.GetFloat("sfxVolume", out sfxvolume);


        PlayerPrefs.SetFloat("sfxVolume", sfxvolume);
        PlayerPrefs.Save();
    }
}
