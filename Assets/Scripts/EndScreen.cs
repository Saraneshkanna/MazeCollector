using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    public void Setup(int score, float gameTime)
    {
        gameTime = Mathf.Round(gameTime * 100f) / 100f; 
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        scoreText.text = "Score:"+score.ToString() + " Points";
        timeText.text = "Time:" + gameTime.ToString() + "s";
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
