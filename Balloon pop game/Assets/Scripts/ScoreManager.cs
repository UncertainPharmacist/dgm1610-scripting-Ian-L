using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //Increase score by a certain amount

        UpdateScoreText();


    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; //decrease score by a certain amount

        UpdateScoreText();


    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;

    }
}
