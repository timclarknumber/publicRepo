using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariablesHeld : MonoBehaviour
{
    public GameObject player;
    public Emotions emotions;
    public int SadJoyHeld = 0;
    public int AngerLoveHeld = 0;
    public int LonelyOverstimulatedHeld = 0;
    public int FearConfidenceHeld = 0;
    void Awake()
    {
        DontDestroyOnLoad(gameObject); //don kill me vro
    }

    // Update is called once per frame
    void Update()
    {
        SadJoyHeld = Mathf.Clamp(SadJoyHeld,-2,2);
        AngerLoveHeld = Mathf.Clamp(AngerLoveHeld,-2,2);
        LonelyOverstimulatedHeld = Mathf.Clamp(LonelyOverstimulatedHeld,-2,2);
        FearConfidenceHeld = Mathf.Clamp(FearConfidenceHeld,-2,2);
        if (GameObject.Find("Player") != null) //is there a player?
        {
            player = GameObject.Find("Player"); //lets do stuff with the player if it exists
            emotions = player.GetComponent<Emotions>(); //maybe find a way to do this so it isnt happening every frame
        } else {
            player = null; //if there isnt a player, dont do stuff with the player
            emotions = null;
        }

        if (player != null)
        { //if the player's variables need to be changed, change em.
            if (emotions.SadJoy == -10)
            {
                emotions.SadJoy = SadJoyHeld;
            }
            if (emotions.AngerLove == -10)
            {
                emotions.AngerLove = AngerLoveHeld;
            }
            if (emotions.LonelyOverstimulated == -10)
            {
                emotions.LonelyOverstimulated = LonelyOverstimulatedHeld;
            }
            if (emotions.FearConfidence == -10)
            {
                emotions.FearConfidence = FearConfidenceHeld;
            }
        }
    }
}
