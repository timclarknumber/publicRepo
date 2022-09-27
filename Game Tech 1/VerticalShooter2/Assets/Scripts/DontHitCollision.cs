using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontHitCollision : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GetScoreKillObject();
    }

    void GetScoreKillObject()
    {
        Destroy(gameObject); //destroy this object
        GameObject.Find("Canvas").GetComponent<ScoreScript>().AddScore(false); //find where the score is displayed, take away 10 from the score
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
}
