using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeds : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
        if (transform.position.x < -11)
            Destroy(gameObject);

    }
}
