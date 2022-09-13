using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentCheckpoint : MonoBehaviour
{
    public Vector2 currentPosForCheck = new Vector2(0.0f, 0.0f); //this public value is changed by other scripts attached to different objects
    //the Vector2 above is the current checkpoint
    //this script exists to store this value
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
