using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectible")
        {
            score++;
        }
    }
}
