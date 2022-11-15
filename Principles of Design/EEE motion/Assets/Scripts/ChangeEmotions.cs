using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmotions : MonoBehaviour
{
    public GameObject holdObject;
    public PlayerVariablesHeld holdScript;
    public int changeSJ = 0;
    public int changeAL = 0;
    public int changeLO = 0;
    public int changeFC = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("PlayerVariableHolder") != null) //is there a player?
        {
            holdObject = GameObject.Find("PlayerVariableHolder"); //lets do stuff with the player if it exists
            holdScript = holdObject.GetComponent<PlayerVariablesHeld>(); //maybe find a way to do this so it isnt happening every frame
        } else {
            holdObject = null; //if there isnt a player, dont do stuff with the player
            holdScript = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (holdObject != null)
        {
            changeEmotionNumbers();
        }
    }

    public void changeEmotionNumbers()
    {
        holdScript.SadJoyHeld += changeSJ;
        holdScript.AngerLoveHeld += changeAL;
        holdScript.LonelyOverstimulatedHeld += changeLO;
        holdScript.FearConfidenceHeld += changeFC;
        Destroy(gameObject);
    }
}
