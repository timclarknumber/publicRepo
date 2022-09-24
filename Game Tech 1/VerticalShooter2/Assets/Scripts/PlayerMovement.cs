using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //tutorial didnt want this to be public, me tho? I want these to public. Now they are public!
    public float xMove = 10f;
    public float xSpeed = 10f;
    public float ySpeed = 5f;
    public float yMove = 10f;
    public float boundsLeft = -2.1f;
    public float boundsRight = 2.1f;
    public float boundsUp = -2f;
    public float boundsDown = -4.45f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //why use getcomponent when the editor exists
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    void CheckInput()
    {
        xMove = Input.GetAxis("Horizontal") * xSpeed;
        yMove = Input.GetAxis("Vertical") * ySpeed;
    }

    void Move()
    {
        Vector2 newVelocity = new Vector2(xMove, yMove);
        rb.velocity = newVelocity;
    }

    void CheckBounds()
    {
        Vector2 maxPosX;
        Vector2 maxPosY;
        //Horizontal
        if (transform.position.x < boundsLeft)
        {
            maxPosX = new Vector2(boundsLeft, transform.position.y);
            transform.position = maxPosX;
        }
        else if (transform.position.x > boundsRight)
        {
            maxPosX = new Vector2(boundsRight, transform.position.y);
            transform.position = maxPosX;
        }
        //Vertical
        if (transform.position.y < boundsDown)
        {
            maxPosY = new Vector2(transform.position.x, boundsDown);
            transform.position = maxPosY;
        }
        else if (transform.position.y > boundsUp)
        {
            maxPosY = new Vector2(transform.position.x, boundsUp);
            transform.position = maxPosY;
        }
    }
}
