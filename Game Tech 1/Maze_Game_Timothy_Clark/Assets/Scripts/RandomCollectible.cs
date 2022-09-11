using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        GetScoreKillObject();
    }

    void GetScoreKillObject()
    {
        Destroy(gameObject);
        GameObject.Find ("Score_Canvas").GetComponent<ScoreScript> ().AddScore ();
    }

}
