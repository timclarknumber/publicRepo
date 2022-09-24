using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public GameObject laserPrefab;
    public GameObject laserRightPrefab;
    public GameObject laserLeftPrefab;
    Transform laserSpawn;
    // Start is called before the first frame update
    void Start()
    {
        laserSpawn = transform.Find("LaserSpawn");
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            FireStraight();
        } else if (Input.GetKeyDown(KeyCode.L))
        {
            FireRight();
        } else if (Input.GetKeyDown(KeyCode.J))
        {
            FireLeft();
        }
    }

    void FireStraight()
    {
        GameObject laser = Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation) as GameObject;
    }

    void FireRight()
    {
        GameObject laser = Instantiate(laserRightPrefab, laserSpawn.position, laserSpawn.rotation) as GameObject;
    }

    void FireLeft()
    {
        GameObject laser = Instantiate(laserLeftPrefab, laserSpawn.position, laserSpawn.rotation) as GameObject;
    }
}
