using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1.6f;
    public float minh = -1f;
    public float maxh = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);

        // Adjust the position to be at the right of the screen
        Vector3 screenRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, Camera.main.nearClipPlane));
        pipes.transform.position = new Vector3(screenRight.x + 1, Random.Range(minh, maxh), 0);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
