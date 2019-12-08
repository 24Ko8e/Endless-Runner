using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturalEnv : MonoBehaviour {

    public float scrollspeedx;
    public float scrollspeedy;
    Vector2 saved;
    MeshRenderer mr;

    // Use this for initialization
    void Awake () {
        mr = GetComponent<MeshRenderer>();
        saved = mr.sharedMaterial.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update () {
        float x = Time.time * scrollspeedx;
        float y = Time.time * scrollspeedy;

        Vector2 offset = new Vector2(x, y);
        mr.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    private void OnDisable()
    {
        mr.sharedMaterial.SetTextureOffset("_MainTex", saved);
    }
}
