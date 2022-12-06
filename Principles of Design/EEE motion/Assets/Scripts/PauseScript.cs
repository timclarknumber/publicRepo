using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool pausedRn = false;
    [SerializeField]private Transform thisTransform;
    // Update is called once per frame
    void Update()
    {

        if(!pausedRn)
        {
            thisTransform.position = new Vector3(5000f, 5000f, 0f);
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                pausedRn = true;
            }
        } else {
            thisTransform.position = new Vector3(960f, 540f, 0f);
        }
    }

    public void Unpause()
    {
        pausedRn = false;
    }
}
