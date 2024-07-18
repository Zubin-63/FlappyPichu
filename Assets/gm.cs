using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;
public class gm : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    public GameObject contin;
    public Text ScoreText;
    public pichu pp;
    public GameObject gamover;
    public GameObject playbutton;
    
    public void Gover()
    {
        Debug.Log("Gameover");
        gamover.SetActive(true);
        playbutton.SetActive(true);
        Pause();
    }
    private void Awake()
    {
        contin.SetActive(false);
        Pause();
    }
    public void Play()
    {
        score = 0;
        ScoreText.text = score.ToString();
        Time.timeScale = 1f;
        gamover.SetActive(false);
        playbutton.SetActive(false);
        pp.enabled = true;
        pipeds[] pipes = FindObjectsOfType<pipeds>();
        
        for(int i=0;i<pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }
    public void Pause()
    {
        Time.timeScale = 0f;
        pp.enabled = false;
       
    }
    public void IncreaseScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
    public void Continu()
    {
        Time.timeScale = 1f;
        contin.SetActive(false);
    }
}
