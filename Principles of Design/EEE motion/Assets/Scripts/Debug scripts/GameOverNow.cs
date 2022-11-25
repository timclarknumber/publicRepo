using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverNow : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("GameOver");
    }
}
