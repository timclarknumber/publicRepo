using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeanieMovesPlayer : MonoBehaviour
{
    public GameObject thePlayer;

    void OnTriggerEnter2D(Collider2D collider)
    {
        thePlayer.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
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