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
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("MoveSpeedX",Mathf.Abs(_rb.velocity.x));
    }
}
