using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private string lastMove;
    private float moveBuffer;
    [SerializeField]private float moveBufferTime = 1;
    [SerializeField]private SceneSwapCombat sceneScript;
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (moveBuffer > 0)
        {
            moveBuffer -= Time.deltaTime;
        }
        if (moveBuffer <= 0) 
        {
            if (Input.GetKeyDown(KeyCode.W)) {
                transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);
                lastMove = "W";
                moveBuffer = moveBufferTime;
            } else if (Input.GetKeyDown(KeyCode.S)) {
                transform.position = new Vector3 (transform.position.x, transform.position.y - 1, transform.position.z);
                lastMove = "S";
                moveBuffer = moveBufferTime;
            } else if (Input.GetKeyDown(KeyCode.A)) {
                transform.position = new Vector3 (transform.position.x - 1f, transform.position.y, transform.position.z);
                lastMove = "A";
                moveBuffer = moveBufferTime;
            } else if (Input.GetKeyDown(KeyCode.D)) {
                transform.position = new Vector3 (transform.position.x + 1f, transform.position.y, transform.position.z);
                lastMove = "D";
                moveBuffer = moveBufferTime;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col) //this happens when the player hits a trigger, which should ALWAYS be a wall.
    {
        //This moves the player back to where they were by doing the opposite of the movement they just did
        if(lastMove == "W")
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y - 1, transform.position.z);
        } else if (lastMove == "S")
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);
        } else if (lastMove == "A")
        {
            transform.position = new Vector3 (transform.position.x + 1, transform.position.y, transform.position.z);
        } else if (lastMove == "D")
        {
            transform.position = new Vector3 (transform.position.x - 1, transform.position.y, transform.position.z);
        }
    }
}
