using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whatLocksMe : MonoBehaviour
{
    [SerializeField]private int tooSJ = 3; //3 means always
    [SerializeField]private int tooAL = 3;
    [SerializeField]private int tooLO = 3;
    [SerializeField]private int tooFC = 3;
    [SerializeField]private Emotions emotionScript;
    [SerializeField]private GameObject player;
	[SerializeField]private Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Player") != null)
        {
            player = GameObject.Find("Player");
            emotionScript = player.GetComponent<Emotions>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player != null)
        {
            if((tooSJ > 0 && emotionScript.SadJoy >= tooSJ) || (tooSJ < 0 && emotionScript.SadJoy <= tooSJ) || (tooAL > 0 && emotionScript.AngerLove >= tooAL) || (tooAL < 0 && emotionScript.AngerLove <= tooAL) || (tooLO > 0 && emotionScript.LonelyOverstimulated >= tooLO) || (tooLO < 0 && emotionScript.LonelyOverstimulated <= tooLO) || (tooFC > 0 && emotionScript.FearConfidence >= tooFC) || (tooFC < 0 && emotionScript.FearConfidence <= tooFC))
            {
                thisButton.interactable = false;
            } else {
                thisButton.interactable = true;
            }
        }
    }
}
