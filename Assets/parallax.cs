using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.05f;
    private MeshRenderer meshRender;
     void Awake()
    {
        meshRender = GetComponent<MeshRenderer>();
    }
    

    // Update is called once per frame
    void Update()
    {
        meshRender.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
