using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemyMovesAt = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * enemyMovesAt);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddScore(false); //punish the player for letting the enemy hit the bottom of the screen.
        }
    }
}
