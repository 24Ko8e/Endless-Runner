using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public GameManager gamemanager;
    public AudioSource crash;
    public AudioSource Engine;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacles")
        {
            Engine.Stop();
            crash.Play();
            movement.enabled = false;
            PlayerMovement.env_scroll = false;
            FindObjectOfType<GameManager>().endgame();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
