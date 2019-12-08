using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {
    public float scrollspeedx = 0f;
    public float scrollspeedy = 0f;
    MeshRenderer mr;
    public GameObject obj;
    Vector2 saved;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        saved = mr.sharedMaterial.GetTextureOffset("_MainTex");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerMovement.env_scroll)
        {
            
                float x = Time.time * scrollspeedx;
                float y = Time.time * scrollspeedy;

                Vector2 offset = new Vector2(x, y);
                mr.sharedMaterial.SetTextureOffset("_MainTex", offset);
            
        }
	}
    private void OnDisable()
    {
        mr.sharedMaterial.SetTextureOffset("_MainTex", saved);
    }
}
