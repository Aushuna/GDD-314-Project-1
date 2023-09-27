using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{


    int count = 0;
    public TextMeshProUGUI scoreText, fixText, endScoreText;
    public GameObject score, endscore;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + count.ToString();
        endScoreText.text = scoreText.text;
    }

    //Adds score to the counter 
    public void AddScore(int newScore)
    {
        count += newScore;
        scoreText.text = "Score: " + count.ToString();
        endScoreText.text = scoreText.text;
    }

    //Gets the score count when called
    public int GetCount()
    {
        return count;
    }
    //sets the score count if needed to be called 
    public void SetCount(int _count)
    {
        count = _count;
    }

    /*subtracts the score from the conter
    public void SubtractScore(int newScore)
    {
        count -= newScore;
        scoreText.text = "Score: " + count.ToString();
    }*/

}
