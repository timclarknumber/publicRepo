using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void restartGameW()
    {
        SceneManager.LoadScene("StartScene");
        if (GameObject.Find("PlayerVariableHolder") != null) //if there is a player variable holder
        {
            Destroy(GameObject.Find("PlayerVariableHolder"));
        }
    }
    public void endGameW()
    {
        Application.Quit();
    }
}
