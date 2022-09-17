using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    float rot = 0f;
    float rotSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Rotate();
    }

    void CheckInput()
    {
        rot = Input.GetAxis("Horizontal") * rotSpeed;
    }

    void Rotate()
    {
        transform.Rotate(0, 0, -rot);
    }
}

