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
        
    }
}
