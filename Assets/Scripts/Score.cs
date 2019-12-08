#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class Score : MonoBehaviour {
    public Transform player;
    public Text scoretext;
    double posi;

// Use this for initialization
void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        posi = (player.position.z + 99.78);
        scoretext.text = posi.ToString("0");
	}
}
#endif
