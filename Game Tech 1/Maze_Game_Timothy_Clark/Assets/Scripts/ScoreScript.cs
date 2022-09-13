using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;//See below

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //Using TextMeshProUGUI instead of just public Text because the Text type is now legacy
    //I found out I had to add using TMPro; and change my Text to TextMeshProUGUI from this thread: https://www.reddit.com/r/Unity3D/comments/fdtuf7/how_can_i_reference_textmeshpro_text_in/
    public int score = 0;

    void Start()
    {

    }

    public void AddScore()
    {
        score++; //add score
        scoreText.text = score.ToString (); //make the score int into a string so it can be displayed
    }
}
