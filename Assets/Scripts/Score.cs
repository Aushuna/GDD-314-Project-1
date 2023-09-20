using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{


    int count = 0;
    public TextMeshProUGUI scoreText, fixText;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + count.ToString();
    }

    //Adds score to the counter 
    public void AddScore(int newScore)
    {
        count += newScore;
        scoreText.text = "Score: " + count.ToString();
    }

    /*subtracts the score from the conter
    public void SubtractScore(int newScore)
    {
        count -= newScore;
        scoreText.text = "Score: " + count.ToString();
    }*/

}
