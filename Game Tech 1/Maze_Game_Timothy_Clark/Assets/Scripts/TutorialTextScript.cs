using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;//See below

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
        if (thePlayer.transform.position.x < 20)
        {
            tutorialText.text = "Welcome to the tutorial! As you move forward this text will update. To move: use either WASD or Arrow Keys.";
        } else if (thePlayer.transform.position.x >= 20 && thePlayer.transform.position.x < 40)
        {
            tutorialText.text = "These are stars, you can collect them to increase your score";
        } else if (thePlayer.transform.position.x >= 40 && thePlayer.transform.position.x < 60)
        {
            tutorialText.text = "Your score will be counted at the end of the game, try to get the highest score you can.";
        } else if (thePlayer.transform.position.x >= 60 && thePlayer.transform.position.x < 80)
        {
            tutorialText.text = "Watch out for meanies! If you touch one, they will send you back to the beginning of the level.";
        }
        else if (thePlayer.transform.position.x >= 80 && thePlayer.transform.position.x < 100)
        {
            tutorialText.text = "You may have noticed the timer, if it runs out, you lose the game! But remaining points will go to your score.";
        }
        else if (thePlayer.transform.position.x >= 100 && thePlayer.transform.position.x < 120)
        {
            tutorialText.text = "This is the exit, by touching it you will proceed to the next level. Good luck!";
        }
    }
}
