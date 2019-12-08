using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public Transform player;
    public Text scoretext;
    double posi;
    public Text highscore;
    int hs;

    // Use this for initialization
    void Start () {
        hs = PlayerPrefs.GetInt("Highscore", 0);
	}
	
	// Update is called once per frame
	void Update () {
        posi = (player.position.z + 99.78);
        if (posi < hs)
        {
            scoretext.text = posi.ToString("0");
            highscore.text = "Highscore : " + hs.ToString("0");
        }

        else
        {
            hs = Convert.ToInt32(posi);
            PlayerPrefs.SetInt("Highscore", Convert.ToInt32(posi));
            highscore.text = "Highscore : " + hs.ToString("0");
        }
    }

}
