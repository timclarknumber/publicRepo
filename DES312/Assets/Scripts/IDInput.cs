using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IDInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void localToGlobal(string localID)
    {
        CloudSaveTest.setID(localID);
    }

    public void continueToGame()
    {
        if (CloudSaveTest.key != "" && CloudSaveTest.key != null)
        {
            CloudSaveTest.SaveIntialize();
            SceneManager.LoadScene("Tutorial2");
        }
    }

    
}
