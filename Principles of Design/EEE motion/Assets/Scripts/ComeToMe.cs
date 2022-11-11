using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeToMe : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    private GameObject player;
    private float playerX;
    private float playerY;
    private float thisX;
    private float thisY;
    [SerializeField]private float donKillMeBro = 1f;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        if (GameObject.Find("Player") != null)
        {
            player = GameObject.Find("Player");
        } else {
            player = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("CombatCanvas") != null)
        {
            donKillMeBro += Time.deltaTime;
        }
        if (GameObject.Find("Player") != null)
        {
            player = GameObject.Find("Player");
        } else {
            player = null;
        }
        donKillMeBro -= Time.deltaTime;
        thisX = transform.position.x;
        thisY = transform.position.y;
        
        if (player != null)
        {
            playerX = player.transform.position.x;
            playerY = player.transform.position.y;
            if(playerX < thisX + 0.5 && playerX > thisX - 0.5 && playerY < thisY + 0.5 && playerY > thisY - 0.5)
            {
                Destroy(gameObject);
            } else if(donKillMeBro < 0) {
                player.transform.position = new Vector3 (thisX, thisY, player.transform.position.z);
            }
        }
    }
}
