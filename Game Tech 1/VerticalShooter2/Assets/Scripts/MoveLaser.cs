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
    public GameObject shrinkLazer;
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
        //this used to be used to kill the laser past a certain distance but I realized it's pretty useless for that, it is however good for the curved path physics calculation. So now it just does that, and spawns shrinks.

        if (transform.position.y > 9)
        {
            Destroy(gameObject);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        CheckLife();
        if (lifeCount % 2 == 0)
        {
            GameObject laserShrunk = Instantiate(shrinkLazer, transform.position, transform.rotation) as GameObject;
        }
    }
    

    void FixedUpdate()
    {
        lifeCount++; //this tracks how far along the laser is on it's path, it used to do other things, now it does not.
        if (curveShotRight)
        {//as the laser travels along it's path, force is added based on how far along it is on that path, tracked by 'life count' as well as how strong the curve is desire to be, changed in the editor, and then this is regulated by Time.deltaTime
            GetComponent<Rigidbody2D> ().AddForce ((transform.right * (-lifeCount * curveStrength)) * Time.deltaTime); 
        } else if (curveShotLeft)
        {
            GetComponent<Rigidbody2D> ().AddForce (transform.right * lifeCount * curveStrength * Time.deltaTime);
        }
    }
}
