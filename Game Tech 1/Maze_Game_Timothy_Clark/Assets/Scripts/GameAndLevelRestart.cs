using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAndLevelRestart : MonoBehaviour
{
    public string firstScene;
    public string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(firstScene);
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(currentScene);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
