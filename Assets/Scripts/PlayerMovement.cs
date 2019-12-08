using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public Rigidbody rb;
    public float forwardspeed = 2000f;
    public float sidespeed = 500f;
    bool carstarted = false;
    public AudioSource Engine;
    public GameObject w;
    public GameObject score;
    public static bool env_scroll;
    public GameObject spawner;

	// Use this for initialization
	void Start () {
        w.SetActive(true);
        score.SetActive(false);
        env_scroll = false;
        spawner.SetActive(false);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!carstarted)
        {
            if (Input.GetKey("w"))
            {
                carstarted = true;
                Engine.Play();
                w.SetActive(false);
                score.SetActive(true);
                env_scroll = true;
                spawner.SetActive(true);
            }
        }
        if (carstarted)
        {
            rb.AddForce(0, 0, forwardspeed * Time.deltaTime);


            if (Input.GetKey("d"))
            {
                rb.AddForce(sidespeed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidespeed * Time.deltaTime, 0, 0);
            }

            if (rb.position.y < -2f)
            {
                FindObjectOfType<GameManager>().endgame();
            }

        }
    }



}
