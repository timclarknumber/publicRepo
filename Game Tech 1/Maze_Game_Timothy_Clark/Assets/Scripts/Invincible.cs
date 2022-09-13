using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{
    //Anything that has this script attached is invincible
    public int ThisObjStaysScene2Scene = 0; //this 'int' just acts a message so it can be seen from the editor that this object is invincible/what this script does. Does not change, changing it does nothing, it is a message.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //dont destroy this object when loading a scene (makes it so the object stays between scenes)
    }
}
