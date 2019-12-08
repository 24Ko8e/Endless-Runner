using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstacles;
    public Transform spawnerposition;
    public float spawnwait;
    public float spawnmostwait;
    public float spawnleastwait;
    public int startwait;
    int randobstacle;
	// Use this for initialization
	void Start () {
        StartCoroutine(waitspawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnwait = Random.Range(spawnleastwait, spawnmostwait);
	}

    IEnumerator waitspawner()
    {
        yield return new WaitForSeconds(startwait);

        Debug.Log("before while");

        while (true)
        {
            Debug.Log("while loop iteration");

            randobstacle = Random.Range(0, 13);
            
                if (randobstacle == 0)
                {
                    Vector3 spawnposition = new Vector3(Random.Range(-1.5f, 1.5f), 0.255f, spawnerposition.position.z);

                    Instantiate(obstacles[randobstacle], spawnposition, gameObject.transform.rotation);
                    yield return new WaitForSeconds(spawnwait);
                }

                if(randobstacle > 0 && randobstacle <9)
                {
                    Vector3 spawnposition = new Vector3(Random.Range(-1.5f, 1.5f), 0.255f, spawnerposition.position.z);

                    Instantiate(obstacles[randobstacle], spawnposition, gameObject.transform.rotation);
                    yield return new WaitForSeconds(spawnwait);
                }
                if(randobstacle >= 9 && randobstacle <=10)
            {
                Vector3 spawnposition = new Vector3(-1.5f, 0.255f, spawnerposition.position.z);
                Vector3 spawnposition2 = new Vector3(1.5f, 0.255f, spawnerposition.position.z);
                Instantiate(obstacles[2], spawnposition, gameObject.transform.rotation);
                Instantiate(obstacles[2], spawnposition2, gameObject.transform.rotation);
                yield return new WaitForSeconds(spawnwait);
            }
                
                
                if(randobstacle >= 11 && randobstacle <= 12)
            {
                Vector3 spawnposition = new Vector3(-1.5f, 0.255f, spawnerposition.position.z);
                Vector3 spawnposition2 = new Vector3(1.5f, 0.255f, spawnerposition.position.z);
                Instantiate(obstacles[4], spawnposition, gameObject.transform.rotation);
                Instantiate(obstacles[3], spawnposition2, gameObject.transform.rotation);
                yield return new WaitForSeconds(spawnwait);
            }
        }
    }
}
