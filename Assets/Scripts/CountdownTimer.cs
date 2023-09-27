using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{

    float currentTime = 0f;
    public float startingTime;
    public Score score;
    public GameObject Table;
    public GameObject BinRed, BinGreen, BinBlue, BinYellow, BinPurple;

    public TextMeshProUGUI countdownText, EndText, Score, EndScore, Timer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        
        //if timer is greater than or equal to zero do _____
        if(currentTime <= 0)
        {
            currentTime = 0;
            Table.gameObject.SetActive(false);
            EndText.gameObject.SetActive(true);
            Timer.gameObject.SetActive(false);
            Score.gameObject.SetActive(false);
            EndScore.gameObject.SetActive(true);
            BinRed.GetComponent<BoxCollider>().enabled = false;
            BinGreen.GetComponent<BoxCollider>().enabled = false;
            BinBlue.GetComponent<BoxCollider>().enabled = false;
            BinYellow.GetComponent<BoxCollider>().enabled = false;
            BinPurple.GetComponent<BoxCollider>().enabled = false;
        }

    }

}
