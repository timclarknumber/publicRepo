using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script changed the level when colliding with an object, it is attached to a prefab object which exists to switch levels.

public class EndLevel : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) //something (usually the player) touches this object
    {
        SceneManager.LoadScene(sceneName); //go to the specified scene
    }
}
