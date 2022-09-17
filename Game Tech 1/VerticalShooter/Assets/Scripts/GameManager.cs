using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public GameObject[] enemyArray;
    public List<GameObject> activeEnemyList;

    void Awake()
    {
        singleton = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        InitEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitEnemies()
    {
        activeEnemyList = new List<GameObject>();
        for (int i = 0; i < enemyArray.Length; i++)
        {
            activeEnemyList.Add(enemyArray[i]);
        }
    }

    public void UnlistEnemy(GameObject enemy)
    {
        for (int i = 0; i < activeEnemyList.Count; i++)
        {
            if (activeEnemyList[i] == enemy)
            {
                activeEnemyList.RemoveAt(i); //remove the clicked enemy from the List
                break;
            }
        }

        if (activeEnemyList.Count == 0)
        {
            StartCoroutine(ResetAllEnemies());
        }
    }

    IEnumerator ResetAllEnemies()
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i < enemyArray.Length; i++)
        {
            enemyArray[i].GetComponent<Enemy>().Respawn();
            activeEnemyList.Add(enemyArray[i]);
        }
    }
}
