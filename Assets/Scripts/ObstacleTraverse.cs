using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTraverse : MonoBehaviour {

    public Transform obsposi;

    bool chk = true;

    public float traversespeed = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (chk)
        {
            transform.Translate(-traversespeed * Time.deltaTime, 0, 0);
        }

        else
        {
            transform.Translate(traversespeed * Time.deltaTime, 0, 0);
        }


        if (obsposi.position.x >= 1.5)
        {
            chk = true;
        }

        if(obsposi.position.x <= -1.5)
        {
            chk = false;
        }

	}
}
