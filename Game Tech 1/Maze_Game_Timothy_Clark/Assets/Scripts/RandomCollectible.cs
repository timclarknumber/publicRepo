using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script used to move the collectibles around randomly, now it just destroys them and adds score when something (usually the player) touches a collectible

public class RandomCollectible : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D collider) //when something (usually the player) touches this object
    {
        GetScoreKillObject(); //destroy the collectible, add score
    }

    void GetScoreKillObject()
    {
        Destroy(gameObject); //destroy this object
        GameObject.Find ("Score_Canvas").GetComponent<ScoreScript> ().AddScore (); //find where the score is displayed, add 1 to the score
    }

}
