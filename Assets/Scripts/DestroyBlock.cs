using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{

    public GameObject Box, Table;
    public Score score;
    public string Tag;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(Tag)) {
            collision.gameObject.SetActive(false);
            Table.gameObject.SetActive(true);
            score.AddScore(1);
            Debug.Log("correct!!");
        }
        else
        {
            //collision.gameObject.SetActive(false);
            Table.gameObject.SetActive(false);
            score.SubtractScore(1);
            Debug.Log("Wrong");
        }
    }
}
