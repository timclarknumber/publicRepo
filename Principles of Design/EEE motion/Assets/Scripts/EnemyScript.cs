using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    [SerializeField]private Transform thisTransform;
    [SerializeField]private SceneSwapCombat sceneScript;
    [SerializeField]private GameObject sceneBruh;
    [SerializeField]private string myName;
    private float playerX;
    private float playerY;
    private float thisX;
    private float thisY;
    // Start is called before the first frame update
    void Start()
    {
        thisX = thisTransform.position.x;
        thisY = thisTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        playerX = playerTransform.position.x;
        playerY = playerTransform.position.y;
        if(playerX < thisX + 0.5 && playerX > thisX - 0.5 && playerY < thisY + 0.5 && playerY > thisY - 0.5)
        {
            sceneScript.GoToCombat(myName);
        }
    }
}
