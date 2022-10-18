using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerRespawn playerRespawn;
    [SerializeField] private SpriteRenderer legColor;
    [SerializeField] private SpriteRenderer handColor;
    [SerializeField] private Transform eyesOpen;
    public bool facingRight = true;
    private Color _handColorActual;
    private Color _legColorActual;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (_handColorActual.r == 1f && _legColorActual.b == 1f) //are the player's hands red and legs blue? If so, that means they aren't attacking (animation changes color of these limbs when attacking)
            { //if they aren't attacking, they are allowed to get hit. This effectively means the player has I-frames when attacking which is just fine.
                Debug.Log("Uh");
                animator.SetBool("PlayerGotHit", true); //the player just got hit! Do the animation.
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (eyesOpen.localScale.y <= 0.05)
        {
            animator.SetBool("PlayerGotHit", false);
            playerRespawn.RespawnThePlayer();
        }
        
        _handColorActual = handColor.color;
        _legColorActual = legColor.color;

        if (facingRight && rb.velocity.x < -0.1)
        {
            Flip();
        } else if (!facingRight && rb.velocity.x > 0.1)
        {
            Flip();
        }

        animator.SetFloat("MoveSpeedX",Mathf.Abs(rb.velocity.x) / playerMovement.XSpeed);
        animator.SetBool("Grounded", playerMovement.IsGrounded);
        if (Input.GetKeyDown("i"))
        {
            animator.SetBool("Punching", true);
        } else {
            animator.SetBool("Punching", false);
        }
        if (Input.GetKeyDown("j"))
        {
            animator.SetBool("MidKicking", true);
        } else {
            animator.SetBool("MidKicking", false);
        }
        if (Input.GetKeyDown("n"))
        {
            animator.SetBool("LowKicking", true);
        } else {
            animator.SetBool("LowKicking", false);
        }
    
    }

    private void Flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
