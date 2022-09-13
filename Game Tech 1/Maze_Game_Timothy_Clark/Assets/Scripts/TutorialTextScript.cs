using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//this scene manages the tutorial text instructing the player
// gp = 'global position'

public class TutorialTextScript : MonoBehaviour
{
    public GameObject thePlayer;
    public TextMeshProUGUI tutorialText;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (thePlayer.transform.position.x < 20) //is the player less than 20 gp in pos?
        {
            tutorialText.text = "Welcome to the tutorial! As you move forward this text will update. To move: use either WASD or Arrow Keys."; //update the tutorial text
        } else if (thePlayer.transform.position.x >= 20 && thePlayer.transform.position.x < 40) //is the player less than 40 but more than 20 gp in pos?
        {
            tutorialText.text = "These are stars, you can collect them to increase your score";  //update the tutorial text
        } else if (thePlayer.transform.position.x >= 40 && thePlayer.transform.position.x < 60)//is the player less than 60 but more than 40 gp in pos?
        {
            tutorialText.text = "Your score will be counted at the end of the game, try to get the highest score you can."; //update the tutorial text
        } else if (thePlayer.transform.position.x >= 60 && thePlayer.transform.position.x < 80)//is the player less than 80 but more than 60 gp in pos?
        {
            tutorialText.text = "Watch out for meanies! If you touch one, they will send you back to the beginning of the level."; //update the tutorial text
        } else if (thePlayer.transform.position.x >= 80 && thePlayer.transform.position.x < 100)//is the player less than 100 but more than 80 gp in pos?
        {
            tutorialText.text = "You may have noticed the timer, if it runs out, you lose the game! But, remaining time will go to your score as points."; //update the tutorial text
        } else if (thePlayer.transform.position.x >= 100 && thePlayer.transform.position.x < 120)//is the player less than 120 but more than 100 gp in pos?
        {
            tutorialText.text = "This is a checkpoint, if you touch it, you will start respawning from this point."; //update the tutorial text
        } else if (thePlayer.transform.position.x >= 120 && thePlayer.transform.position.x < 140)//is the player less than 140 but more than 120 gp in pos?
        {
            tutorialText.text = "Remember you can also pause the game with space at any time, restart the current level with r, or restart the game with tab"; //update the tutorial text
        }else if (thePlayer.transform.position.x >= 140 && thePlayer.transform.position.x < 160)//is the player less than 160 but more than 140 gp in pos?
        {
            tutorialText.text = "This is the exit, by touching it you will proceed to the next level. Good luck!"; //update the tutorial text
        }
    }
}
