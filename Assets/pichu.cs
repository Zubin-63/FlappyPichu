using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pichu : MonoBehaviour

{
    public GameObject contin;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    // Start is called before the first frame update

    // Update is called once per frame
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            contin.SetActive(true);


        }
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0)) {
            direction = Vector3.up * strength;
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obst"||gameObject.transform.position.y<-5||gameObject.transform.position.y>5)
        {
            FindObjectOfType<gm>().Gover();
        }
        else if (collision.gameObject.tag == "score")
        {
            FindObjectOfType<gm>().IncreaseScore();
        }
    }
}
