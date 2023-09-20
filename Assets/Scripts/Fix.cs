using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fix : MonoBehaviour
{

    public GameObject Box;
    public Score score;
    public string Tag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tag))
        {
            collision.gameObject.SetActive(false);
            score.AddScore(1);
            Debug.Log("correct!!");
        }
        else
        {
            //collision.gameObject.SetActive(false);
            score.SubtractScore(1);
            Debug.Log("Wrong");
        }
    }
}
