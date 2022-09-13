using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script will switch the scene when the player (ie the user, not the object) uses left mouse

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    public GameObject canvas;
    // Update is called once per frame
    void Update()
    {
        canvas = GameObject.Find("Score_Canvas");
        CheckStart(); //if the player clicks, change the scene
    }

    void Start()
    {

    }

    void CheckStart()
    {
        {
            if (Input.GetMouseButtonDown (0)) //check if the player (ie the user, not the object) has clicked
            {
                Destroy(canvas);
                //Change the scene name depending on which script you are on.
                //Note that this will require that each SceneManager has a string.
                //typed into the Unity Inspector sceneName.
                SceneManager.LoadScene (sceneName); //change the scene
            }
        }
    }
}
