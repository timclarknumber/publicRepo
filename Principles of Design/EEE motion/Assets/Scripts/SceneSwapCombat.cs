using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapCombat : MonoBehaviour
{
    [SerializeField]private RectTransform healthTransform;
    [SerializeField]private bool fromCombatToOverworld; //this bool decides what the purpose of this scene swap object the script is attached to is.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fromCombatToOverworld) { //this conditional makes sure to only check for the health bar if this is the combat scene, if not, don't check for it because it doesn't exist.
            if(healthTransform.localScale.x < 0.05 ) //this should NEVER result in a null reference exception because of the previous if
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void GoToCombat(string EnemyName)
    {
        SceneManager.LoadScene("CombatScreen");
    }

    public void GoToOverworld()
    {
        SceneManager.LoadScene("Overworld");
    }
}
