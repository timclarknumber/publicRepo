using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserControls : MonoBehaviour
{
    public string firstScene;
    public string currentScene;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) //player pressed tab
        {
            SceneManager.LoadScene(firstScene); //load the first scene
        }
        if (Input.GetKeyDown("r")) //player pressed r
        {
            SceneManager.LoadScene(currentScene); //reload current scene
        }
        if (Input.GetKey("escape")) //player pressed escape
        {
            Application.Quit(); //exit the application
        }
    }
}
