using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is a debugging script, not used in game (or shouldnt be [but if it is, not big deal])

public class CollisionScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log ("OnCollisionEnter2D");
    }
    
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log ("OnCollisionExit2D");
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log ("OnCollisionStay2D");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
