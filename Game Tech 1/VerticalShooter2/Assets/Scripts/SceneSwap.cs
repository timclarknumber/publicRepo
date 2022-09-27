using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckStart();
    }
    void CheckStart()
    {
        {
            if (Input.GetMouseButtonDown(0)) //check if the player (ie the user, not the object) has clicked
            {
                //Change the scene name depending on which script you are on.
                //Note that this will require that each SceneManager has a string.
                //typed into the Unity Inspector sceneName.
                SceneManager.LoadScene(sceneName); //change the scene
            }
        }
    }
}
