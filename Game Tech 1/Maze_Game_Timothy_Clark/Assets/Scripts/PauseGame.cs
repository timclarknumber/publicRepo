using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool pausedOrNot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (!pausedOrNot)
            {
                Time.timeScale = 0;
                pausedOrNot = true;
            } else
            {
                Time.timeScale = 1;
                pausedOrNot = false;
            } //This method based on the method taught at https://gamedevbeginner.com/the-right-way-to-pause-the-game-in-unity/ but there is some variation.
        }
    }
}
