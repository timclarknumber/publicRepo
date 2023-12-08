using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    // Start is called before the first frame update
    public static void MoveToNextScene(string nextScene)
    {
        if (nextScene == null || nextScene == "")
        {
            SceneManager.LoadScene("NoTime");
        } else
        {
            Telemetry.writeToFile("Scene Swap");
            Telemetry.resetDelayTimer();
            SceneManager.LoadScene(nextScene);
        }
        //IMPORTANT: if you are looking for the money telemetry function call, check sceneScopeStats
    }
    public static void ExitTutorial()
    {
        Telemetry.resetDelayTimer();
        SceneManager.LoadScene("Tutorial");
    }
}
