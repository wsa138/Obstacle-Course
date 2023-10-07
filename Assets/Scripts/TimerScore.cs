using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScore : MonoBehaviour
{
    private float startTime;
    private float playTime;
    private float finalScore;

    public Scorer totalHits;

    private bool win = false;
    private bool endScore = false;
    private bool startGame = false;

    [SerializeField] TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        timeText.text = playTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame == false)
        {
            Time.timeScale = 0f;
            return;
        }

        ResetSceneCheck();        

        playTime = Time.time - startTime;

        if (win == true)
        {
            Debug.Log(playTime);
            win = false;
            endScore = true;
        }

        if (endScore == true)
        {
            return;
        }

        timeText.text = playTime.ToString("F2");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            winner();
            collision.gameObject.tag = "Hit";
        }
    }

    void winner()
    {
        win = true;
        finalScore = playTime + totalHits.hits;
        Debug.Log("Score: " + playTime + totalHits.hits + " --- Total Hits: " + totalHits.hits);
        timeText.text = finalScore.ToString("F2");
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        startGame = true;
        Time.timeScale = 1f;
        Debug.Log("Game Started");
    }

    private void ResetSceneCheck()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
