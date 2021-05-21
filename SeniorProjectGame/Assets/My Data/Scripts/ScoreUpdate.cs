using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreUpdate : MonoBehaviour
{

    public int count;
    public float winClock = 0f;
    public float startClock = 0f;
    public float endClock = 0f;

    //public string stringScoreText;

    public Text scoreText;
    public Text youHaveWon;
    public Text winClockScore;

    bool playerHasWon = false;
    bool firstWin = true;

    void Start()
    {
        youHaveWon.enabled = false;
        winClockScore.enabled = false;
        count = 0;
        startClock = Time.time;
        //DontDestroyOnLoad(gameObject);
        //if (GameObject.Find("Player").GetComponent<ScoreUpdate>().winClock > 0f)
        //{
        //    DestroyObject(gameObject);
        //}
    }

    void UpdateScoreText()
    {
        scoreText.text = "Boxes Found: " + count + "/10";
        //Debug.Log(count);
    }

    void UpdateWinText()
    {
        youHaveWon.enabled = true;
        youHaveWon.text = "You Win!!!!";
        winClockScore.enabled = true;
        winClockScore.text = "Your Time: " + endClock.ToString("0.0");// + " Best Time: " + winClock.ToString("0.0");
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(6);
        //stringScoreText = scoreText.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void PlayerWinClock()
    {
        if (playerHasWon == true & firstWin == true)
        {
            endClock = Time.time - startClock;
            if (endClock >= winClock)
            {
                winClock = endClock;
            }
            Debug.Log(winClock);
            StartCoroutine(waiter());
            firstWin = false;
        }
    }

    void Update()
    {
        UpdateScoreText();
        if (count == 10)
        {
            playerHasWon = true;
            PlayerWinClock();
            UpdateWinText();
        }
    }

}
