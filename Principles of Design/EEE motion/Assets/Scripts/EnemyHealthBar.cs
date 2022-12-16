using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField]private RectTransform thisTransform;
    [SerializeField]private GameObject variableHolder;
    [SerializeField]private GameObject sceneSwapper;
    [SerializeField]private GameObject winStateCounter;
    [SerializeField]private EnemyInfoHolder enemyInfoHeld;
    [SerializeField]private SceneSwapCombat sceneScript;
    [SerializeField]private WinScript winScript;
    [SerializeField]private float healthActual;
    [SerializeField]private float barLowerByRate;
    
    private float swapBuffer = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        variableHolder = GameObject.Find("EnemyInfoHolder");
        enemyInfoHeld = variableHolder.GetComponent<EnemyInfoHolder>();
        sceneSwapper = GameObject.Find("SceneSwapManager");
        sceneScript = sceneSwapper.GetComponent<SceneSwapCombat>();
        healthActual = enemyInfoHeld.enemyHealth;
        barLowerByRate = thisTransform.localScale.x / healthActual;
        if (GameObject.Find("WinStateCounter") != null)
        {
            winStateCounter = GameObject.Find("WinStateCounter");
            winScript = winStateCounter.GetComponent<WinScript>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        thisTransform.localScale = new Vector3(healthActual * barLowerByRate, thisTransform.localScale.y, thisTransform.localScale.z); //change the size of the object according to health
        //this change is relative to whatever the health was when the combat scene was first loaded
        if (healthActual <= 0) 
        {
            swapBuffer -= Time.deltaTime;
        }

        if (swapBuffer <= 0)
        {
            iDied();
        }
    }

    public void lowerEnemyHealthBar(float damage)
    {
        healthActual -= damage;
    }

    private void iDied()
    {
        winScript.enemiesNeededDown();
        sceneScript.GoToOverworld(); //go to the overworld when the enemy dies
    }
}
