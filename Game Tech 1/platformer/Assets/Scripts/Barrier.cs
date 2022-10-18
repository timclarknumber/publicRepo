using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private float whatBarrierThisIs; //0 is green 1 is yellow 2 is red
    [SerializeField] private SpriteRenderer handColor;
    [SerializeField] private SpriteRenderer legColor;
    private Color _handColorActual;
    private Color _legColorActual;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _handColorActual = handColor.color;
        _legColorActual = legColor.color;
    }

    
    void OnTriggerEnter2D(Collider2D other) //Did something just hit me?
    {
        if (_handColorActual.r != 1f) //is the hand not red? If it isn't red (white is red cuz rgb), then it must be green (hand animation makes hand become green when it's normally white)
        {
            if (whatBarrierThisIs == 0) //this is the green barrier.
            {
                Destroy(gameObject);
            }
        }
        if (_legColorActual.g == 1f && _legColorActual.b != 1f) //is the leg not blue but is green? If so, then it must be yellow (animation makes leg become yellow)
        {
            if (whatBarrierThisIs == 1) //this is the yellow barrier.
            {
                Destroy(gameObject);
            }
        }
        if (_legColorActual.g != 1f) //is the leg not green? If it isn't green (white is green cuz rgb), then it must be red (animation makes leg become red)
        {
            if (whatBarrierThisIs == 2) //this is the red barrier.
            {
                Destroy(gameObject);
            }
        }
    }
}
