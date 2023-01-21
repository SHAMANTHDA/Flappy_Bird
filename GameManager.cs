using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;

    public Text scoreText;

    public GameObject PlayButton;

    public GameObject gameover;

    public GameObject getready;

    private int score;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }



    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();


        PlayButton.SetActive(false);
        gameover.SetActive(false);
        getready.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameover.SetActive(true);
        PlayButton.SetActive(true);

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
}
