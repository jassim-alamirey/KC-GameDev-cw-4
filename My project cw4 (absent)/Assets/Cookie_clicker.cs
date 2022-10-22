using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cookie_clicker : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public int inc = 1;
    int price = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PressMe()
    {
        score+= inc;
        scoreText.text = "score: "+score.ToString();
    }

    public void shop()
    {
        if (score >= price)
        {
            inc++;
            score-=price;
            scoreText.text = "score: " + score.ToString();
        }
            
    }
}