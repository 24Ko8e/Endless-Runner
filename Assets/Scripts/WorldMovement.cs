using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovement : MonoBehaviour {

    public Transform player;
    public static float distancetravelled = 0;
    float lastposition;

	// Use this for initialization
	void Start () {
        lastposition = player.position.z;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        distancetravelled = player.position.z - lastposition;
        lastposition = player.position.z;
        transform.Translate(0, 0, distancetravelled);
    }
}
