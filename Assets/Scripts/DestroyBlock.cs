using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyBlock : MonoBehaviour
{

    public GameObject Box, Table;
    public TextMeshProUGUI fixText;
    public Score score;
    public string Tag;

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag(Tag)) {
            
            //sets the box object to false if correct
                collision.gameObject.SetActive(false);
            
            //sets spawner to active 
                Table.gameObject.SetActive(true);
            
            //text telling you to fix your error
                fixText.gameObject.SetActive(false);
            
            
            //adds to the score counter
                score.AddScore(1);
                
            
            //Debug.Log("correct!!");
        }
        else
        {
            collision.gameObject.SetActive(false);

            //sets spawner to false
            //Table.gameObject.SetActive(false);

            //enables text telling you to fix your error
           // fixText.gameObject.SetActive(true);

             
            //score.SubtractScore(1);
            //Debug.Log("Wrong");
        }
    }
}
