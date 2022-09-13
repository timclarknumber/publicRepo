using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script will reload the current scene, load the start scene, or exit the application depending on which button is pressed

public class GameAndLevelRestart : MonoBehaviour
{
    public string firstScene;
    public string currentScene;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Score_Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) //player pressed tab
        {
            SceneManager.LoadScene(firstScene); //load the first scene
            Destroy(canvas);
        }
        if (Input.GetKeyDown("r")) //player pressed r
        {
            SceneManager.LoadScene(currentScene); //reload current scene
            Destroy(canvas);
        }
        if (Input.GetKey("escape")) //player pressed escape
        {
            Application.Quit(); //exit the application
        }
    }
}
