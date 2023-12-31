using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLaser : MonoBehaviour
{
    public float laserMovesAt = 500;
    public float laserLife = 60f;
    float lifeCount = 0f;
    public float curveStrength = 1;
    public bool curveShotRight;
    public bool curveShotLeft;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().AddForce (transform.up * laserMovesAt);
        if (curveShotRight)
        {
            GetComponent<Rigidbody2D> ().AddForce (transform.right * laserMovesAt);
        } else if (curveShotLeft)
        {
            GetComponent<Rigidbody2D> ().AddForce (transform.right * -laserMovesAt);
        }
    }

    void CheckLife()
    {
        lifeCount++;
        if (lifeCount == laserLife)
        {
            Destroy(gameObject);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        CheckLife();
    }
    

    void FixedUpdate()
    {
        if (curveShotRight)
        {
            GetComponent<Rigidbody2D> ().AddForce (transform.right * (-lifeCount * curveStrength));
        } else if (curveShotLeft)
        {
            GetComponent<Rigidbody2D> ().AddForce (transform.right * lifeCount * curveStrength);
        }
    }
}
