using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GetScoreKillObject();
    }

    void GetScoreKillObject()
    {
        Destroy(gameObject); //destroy this object
        GameObject.Find("Canvas").GetComponent<ScoreScript>().AddScore(true); //find where the score is displayed, add 5 to the score
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
}
