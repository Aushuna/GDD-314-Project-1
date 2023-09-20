using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{


    int count = 0;
    public TextMeshProUGUI scoreText;

    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        //scoreText = score.GetComponent<TextMeshProUGUI>();

        scoreText.text = "Score: " + count.ToString();
    }

    // Update is called once per frame
    public void AddScore(int newScore)
    {
        count += newScore;
        scoreText.text = "Score: " + count.ToString();
    }
    public void SubtractScore(int newScore)
    {
        count -= newScore;
        scoreText.text = "Score: " + count.ToString();
    }

}
