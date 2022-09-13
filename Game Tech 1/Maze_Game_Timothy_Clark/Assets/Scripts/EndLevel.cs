using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//this script changed the level when colliding with an object, it is attached to a prefab object which exists to switch levels.

public class EndLevel : MonoBehaviour
{
    public float timeHolder;
    public string sceneName;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerTitle;
    public ScoreScript scoreScript;
    public TimerScript timerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeHolder = timerScript.timeLeft; //make sure the value used in the function call below as a parameter is updating to the current time left
    }

    void OnTriggerEnter2D(Collider2D collider) //something (usually the player) touches this object
    {
        scoreScript.AddTimeToScore((int)timeHolder); //this calls a function in another script which adds time to the score with the time as a parameter
        Destroy(timerText); //get rid of the timer text
        Destroy(timerTitle); //get rid of the timer title
        SceneManager.LoadScene(sceneName); //go to the specified scene

    }
}
