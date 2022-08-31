using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    float xMove = 0f;
    float yMove = 0f;
    Rigidbody2D rb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void CheckInput()
    {
        xMove = Input.GetAxis ("Horizontal");
        yMove = Input.GetAxis ("Vertical");
    }

    void MovePlayer()
    {
        rb.AddForce (new Vector2 (xMove, yMove) * speed);
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        MovePlayer();
    }
}
