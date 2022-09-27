using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script will reload the current scene, load the start scene, or exit the application depending on which button is pressed

public class GameAndLevelRestart : MonoBehaviour
{
    public string firstScene;
    public string currentScene;
    public string loseStateScene;
    public string winStateScene;
    public GameObject canvas;
    public ScoreScript scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas"); //find the score UI object
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) //player pressed tab
        {
            SceneManager.LoadScene(firstScene); //load the first scene
            Destroy(canvas); //deletes the score ui, why? Because the start scene has an instance of that object.
            //If this is not done multiple score UI objects will stack because loading the scene will not get rid of the game level's UI objects, they are 'invincible'
        }
        if (Input.GetKeyDown("r")) //player pressed r
        {
            SceneManager.LoadScene(currentScene); //reload current scene
            Destroy(canvas); //same problem as previously solved by destroying the score UI
        }
        if (Input.GetKey("escape")) //player pressed escape
        {
            Application.Quit(); //exit the application
        }
        if (scoreScript.score < -20)
        {
            SceneManager.LoadScene(loseStateScene); //load the lose state scene
        } else if (scoreScript.score > 25)
        {
            SceneManager.LoadScene(winStateScene); //load the win state scene
        }    
    }
}
