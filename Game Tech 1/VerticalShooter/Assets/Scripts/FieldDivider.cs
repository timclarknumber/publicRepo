using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FieldDivider : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public float additionalDistance;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0.0f, playerMovement.boundsUp + additionalDistance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
