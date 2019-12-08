using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCar : MonoBehaviour {

    int setcar;
    public GameObject[] cars;

	// Use this for initialization
	void Start () {
        setcar = PlayerPrefs.GetInt("carpref", 0);

        for (int i = 0; i <= setcar; i++)
        {
            if (i == setcar)
            {
                cars[i].SetActive(true);
            }

            if (i != setcar)
            {
                cars[i].SetActive(false);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
