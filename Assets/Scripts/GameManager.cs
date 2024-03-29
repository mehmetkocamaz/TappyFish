using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static Vector2 bottomLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject getReadyPanel;
    public static int gameScore;
    public GameObject score;

    public static bool gameStarted;
    // Start is called before the first frame update

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {
        gameOver = false;
        gameStarted = false;
    }

    public void GameHasStarted()
    {
        gameStarted = true;
        getReadyPanel.SetActive(false);
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        score.SetActive(false);
        gameScore = score.GetComponent<Score>().GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
