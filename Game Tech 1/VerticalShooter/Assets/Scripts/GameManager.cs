using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public GameObject[] enemyArray;
    public List<GameObject> activeEnemyList;
    GameObject[] totalHealthArray;
    int totalHealth;
    int currentTotalHealthArrayIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        InitEnemies();
        totalHealth = Health.maxPlayerHealth = Health.currentPlayerHealth = InitHealth(); //assign all total health values at once
        Debug.Log(totalHealth);
    }

    void Awake()
    {
        singleton = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public int InitHealth() //initialize health variables, array and return accumulator value
    {
        int accumulator = 0;
        totalHealthArray = GameObject.FindGameObjectsWithTag("Heart"); //load up totalHealthArray with any objects tagged "Heart" 
        //iterate over all hearts and sum maxHealth
        for (int i = 0; i < totalHealthArray.Length; i++)
        {
            accumulator += totalHealthArray[i].GetComponent<Heart>().maxHealth; //accumulate all maxHealth values
            Debug.Log(totalHealthArray[i].GetComponent<Heart>().name);
        }
        return accumulator;
    }

    public void UpdateHealth(int damage = 0) //notice the inline initialization of damage to zero!
    {
        // Unity's Hierarchy will return the order of objects as set in the Hierarchy
        // so iterating over an array will result in the same sequence as shown top-to-bottom in the hierarchy.
        // reordering objects in the Hierarchy will also reorder them in the array totalHealthArray[].

        if (Health.currentPlayerHealth > 0)
        {
            if (currentTotalHealthArrayIndex < totalHealthArray.Length)
            {
                if (totalHealthArray[currentTotalHealthArrayIndex].GetComponent<Heart>().currentHealth > 0) //this test must not be evaluated with an out of bounds index
                {
                    totalHealthArray[currentTotalHealthArrayIndex].GetComponent<Heart>().Damage(damage);
                }
                else if (currentTotalHealthArrayIndex < totalHealthArray.Length)
                {
                    currentTotalHealthArrayIndex++;
                    UpdateHealth(); //notice this example of recursion is not in a recursive loop!
                }
            }
            // this function needs to update the total health variable: totalHealth
            totalHealth -= damage;
            Health.currentPlayerHealth = totalHealth;
        }
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


