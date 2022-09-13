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
        timeHolder = timerScript.timeLeft;
    }

    void OnTriggerEnter2D(Collider2D collider) //something (usually the player) touches this object
    {
        scoreScript.AddTimeToScore((int)timeHolder);
        Destroy(timerText);
        Destroy(timerTitle);
        SceneManager.LoadScene(sceneName); //go to the specified scene

    }
}
