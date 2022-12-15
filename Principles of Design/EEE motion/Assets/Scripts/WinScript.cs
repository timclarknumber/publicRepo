using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public int enemiesNeeded;
    [SerializeField]private string winLevelName;
    // Start is called before the first frame update
    public void enemiesNeededDown()
    {
        enemiesNeeded--;
    }

    void Update()
    {
        if(enemiesNeeded <= 0)
        {
            SceneManager.LoadScene(winLevelName);
        }
    }
}
