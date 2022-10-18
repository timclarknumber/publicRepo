using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BEWARE. This script contains animations relating to things BESIDES the enemy getting hit. Check EnemyGetsHit for what relates to the enemy getting hit, including it's animation!
//Also, the enemy stopping and thinking isn't an animation, it's just using its idle animation and EnemyAI tells it when to set its velocity to 0 so the idle animation will trigger. 

public class EnemyAnimations : MonoBehaviour
{
    [SerializeField] private EnemyAI enemyAI;
    [SerializeField] private Animator animator;
    private Rigidbody2D _rb;
    private int  whichAttackShouldIDo = -1; //0 == hipunch, 1 == midkick, 2 == lowkick. 
    //DONT USE FLOATS, THERE SHOULD ONLY BE 3 STATES AND THE RANDOM RANGE WILL GIVE LIKE A BILLION IF YOU TRY TO MAKE IT USE FLOATS
    //Putting this note here for myself in case I forget.
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //this code lets the animator know if the enemy is moving or not
        animator.SetFloat("MoveSpeedX",Mathf.Abs(_rb.velocity.x));

        whichAttackShouldIDo = Random.Range(0, 2);

        if (enemyAI.IShouldAttack)
        {
            if (whichAttackShouldIDo == 0)
            {
                animator.SetBool("Punching", true);
                enemyAI.IShouldAttack = false;
                enemyAI.ableToAttack = 0f;
            }
            if (whichAttackShouldIDo == 1)
            {
                animator.SetBool("MidKicking", true);
                enemyAI.IShouldAttack = false;
                enemyAI.ableToAttack = 0f;
            }
            if (whichAttackShouldIDo == 2)
            {
                animator.SetBool("LowKicking", true);
                enemyAI.IShouldAttack = false;
                enemyAI.ableToAttack = 0f;
            }
        } else {
            animator.SetBool("Punching", false);
            animator.SetBool("MidKicking", false);
            animator.SetBool("LowKicking", false);
        }
    }
}
