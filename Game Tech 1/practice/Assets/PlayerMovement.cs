using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 0f;
    public float jumpSpeed = 10f;
    public LayerMask groundLayer;

    private float _moveInput; //-1 to 1 on x axis
    private bool _jumpPressed; //Was the jump button pressed this frame?
    private bool _grounded;

    // Update is called once per frame
    void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpPressed = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _grounded ? Color.green : Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }

    private void FixedUpdate()
    {
        _grounded = Physics2D.OverlapCircle(transform.position, 0.1f, groundLayer);

        rb.velocity = new Vector2(_moveInput * moveSpeed * Time.deltaTime, rb.velocity.y);
        if (_jumpPressed)
        {
            if (_grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
            _jumpPressed = false;
        }
    }

}
