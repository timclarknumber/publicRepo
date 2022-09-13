using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeanieMove : MonoBehaviour
{
    public bool meanieHorV; //false is Horizontal, true is Vertical
    public float xExtentRight; //farthest extent to the right the meanie will go (global pos)
    public float xExtentLeft; //farthest extent to the left the meanie will go (global pos)
    public float yExtentUp; //farthest extent up the meanie will go (global pos)
    public float yExtentDown; //farthest extent down the meanie will go (global pos)
    public float meanieSpeed; //speed meanie travels
    bool forwardOrBackward = true; //whether the meanie is currently going forward or backward, true is forward & vv, forward for H is right & vv, forward for V is up & vv
    Vector3 newPosition = new Vector3(0.0f, 0.0f, 0.0f);

    void moveTheMeanieV()
    {
        if (forwardOrBackward) //meanie is going forward (up)
        {
            if (newPosition.y < yExtentUp) //meanie is not yet past farthest extent upward
            {
                newPosition.y += meanieSpeed * Time.deltaTime; //meanie moves up
            }
            else //meanie is past farthest extent upward
            {
                forwardOrBackward = false; //meanie will now go backwards (down)
            }
        }
        else //meanie is going backward (down)
        {
            if (newPosition.y > yExtentDown) //meanie is not yet past farthest extent downard
            {
                newPosition.y -= meanieSpeed * Time.deltaTime; //meanie moves down
            }
            else //meanie is past farthest extent downward;
            {
                forwardOrBackward = true; //meanie will now go forwards (up)
            }
        }
    }

    void moveTheMeanieH()
    {
        if (forwardOrBackward) //meanie is going forward (right)
        {
            if (newPosition.x < xExtentRight) //meanie is not yet past farthest extent to the right
            {
                newPosition.x += meanieSpeed * Time.deltaTime; //meanie moves to the right
            }
            else //meanie is past farthest extent to the right
            {
                forwardOrBackward = false; //meanie will now go backwards (left)
            }
        }
        else //meanie is going backward (left)
        {
            if (newPosition.x > xExtentLeft) //meanie is not yet past farthest extent downard
            {
                newPosition.x -= meanieSpeed * Time.deltaTime; //meanie moves left
            }
            else //meanie is past farthest extent to the left;
            {
                forwardOrBackward = true; //meanie will now go forwards (right)
            }
        }
    }

    void moveTheMeanie()
    {
        if (meanieHorV) //meanie is going Vertically
        {
            moveTheMeanieV();
        }
        else  //meanie is going Horizontally
        {
            moveTheMeanieH();
        }
        transform.localPosition = newPosition; //moves the meanie
    }

    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.localPosition; //set the variable used to track meanie's pos to the position of meanie at game start
    }

    // Update is called once per frame
    void Update()
    {
        moveTheMeanie(); //moves the meanie every frame
    }
}