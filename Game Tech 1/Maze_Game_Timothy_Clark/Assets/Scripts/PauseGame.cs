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
                Time.timeScale = 0; //freeze time
                pausedOrNot = true; //the game is now paused
            }
            else
            {
                Time.timeScale = 1; //unfreeze time
                pausedOrNot = false; //the game is now unpaused
            } //This method based on the method taught at https://gamedevbeginner.com/the-right-way-to-pause-the-game-in-unity/ but there is some variation.
        }

        if (Input.GetKeyDown("tab"))
        {
            Destroy(gameObject); //if the player pressed tab, it means they are using a different script to go back to the start of the game
            //this means the pause object needs to be destroyed, or else multiple versions of it will exist at once
        }
    }
}
