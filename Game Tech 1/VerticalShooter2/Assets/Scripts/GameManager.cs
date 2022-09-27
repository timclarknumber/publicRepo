using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public GameObject healthPanel;
    public HealthBar healthBar;
    public GameObject dontHit;
    public GameObject enemyHL;
    public GameObject enemyHR;
    public GameObject enemyHD;
    public GameObject enemyHU;
    GameObject EnemyToSpawn;
    public float rando;
    public float enemySpawnHeight = 0f;
    //public GameObject[] enemyArray; old code
    //public List<GameObject> activeEnemyList;
    //GameObject[] totalHealthArray;
    int totalHealth;
    int currentTotalHealthArrayIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        //old code
        //enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        //InitEnemies();
        //totalHealth = Health.maxPlayerHealth = Health.currentPlayerHealth = InitHealth(); //assign all total health values at once
        //Debug.Log(totalHealth);
    }

    void Awake()
    {
        singleton = this;
    }
    /* old code
    public static void DoDamage()
    {
        healthPanel = healthBar.LoseHealth();
    }
    */
    // Update is called once per frame
    void Update()
    {
        rando = Random.Range(1, 4); //this random number is used to determine which enemy to spawn
        if (rando == 1) //this if statement (could have been a switch statement I guess but whatever) uses the rando float to assign an enemy prefab to the enemytospawn
        {
            EnemyToSpawn = enemyHL;
        } else if (rando == 2)
        {
            EnemyToSpawn = enemyHR;
        } else if (rando == 3)
        {
            EnemyToSpawn = enemyHD;
        } else if (rando == 4)
        {
            EnemyToSpawn = enemyHU;
        }

        if (GameObject.Find ("EnemyHL(Clone)") || GameObject.Find("EnemyHD(Clone)") || GameObject.Find("EnemyHR(Clone)") || GameObject.Find("EnemyHU(Clone)")) //checks if there is any enemy in the scene that is one of the prefabs
        { //it *works*
            Debug.Log("it exists"); //lets me, the designer, confirm that an enemy is on screen.
        } else
        {
            GameObject enemy = Instantiate(EnemyToSpawn, new Vector3(Random.Range(-3f,3f), enemySpawnHeight, 0f), new Quaternion(0f, 0f, 0f, 0f)) as GameObject; //if there isnt an enemy in scene that is an enemy prefab, spawn one at a random position on the x within a range and at a specific height.
        }
    }

    /* old code
    public int InitHealth() //initialize health variables, array and return accumulator value
    {
        int accumulator = 0;
        totalHealthArray = GameObject.FindGameObjectsWithTag("Heart"); //load up totalHealthArray with any objects tagged "Heart" 
        iterate over all hearts and sum maxHealth
        for (int i = 0; i < totalHealthArray.Length; i++)
        {
            accumulator += totalHealthArray[i].GetComponent<Heart>().maxHealth; //accumulate all maxHealth values
            Debug.Log(totalHealthArray[i].GetComponent<Heart>().name);
        }
        return accumulator;
    }

    public void UpdateHealth(int damage = 0) //notice the inline initialization of damage to zero!
    {
         Unity's Hierarchy will return the order of objects as set in the Hierarchy
         so iterating over an array will result in the same sequence as shown top-to-bottom in the hierarchy.
         reordering objects in the Hierarchy will also reorder them in the array totalHealthArray[].

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
    */

}


