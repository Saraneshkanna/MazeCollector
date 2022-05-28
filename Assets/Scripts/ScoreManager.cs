using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    private float gameTime = 0f;
    public EndScreen endScreen;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    private void FixedUpdate()
    {
        gameTime += 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            score += 2;
        }
        else if(other.tag == "Ruby")
        {
            score += 5;
        }
        else if(other.tag == "End")
        {
            //SceneManager.LoadScene("EndScene");
            endScreen.Setup(score, gameTime);
        }
    }
}
