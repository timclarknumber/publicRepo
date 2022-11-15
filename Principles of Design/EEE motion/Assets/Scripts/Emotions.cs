using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotions : MonoBehaviour
{
    public int SadJoy;
    public int AngerLove;
    public int LonelyOverstimulated;
    public int FearConfidence;
    // Start is called before the first frame update
    void Start()
    {
        SadJoy = -10; //-10 means 'give me a value'
        AngerLove = -10;
        LonelyOverstimulated = -10;
        FearConfidence = -10;
    }

    // Update is called once per frame
    void Update()
    {
        if (SadJoy != -10 && AngerLove != -10 && LonelyOverstimulated != -10 && FearConfidence != -10) //dont correct values if looking for a value.
        {
            //these functions calls are basically math clamps but im not familiar with hose those work and I don't trust them so... yea
            SadJoy = Corrected(SadJoy);
            AngerLove = Corrected(AngerLove);
            LonelyOverstimulated = Corrected(LonelyOverstimulated);
            FearConfidence = Corrected(FearConfidence);
        }
    }

    public int Corrected(int wrong)
    {
        if (wrong > 2)
        {
            wrong = 2;
        } else if (wrong < -2)
        {
            wrong = -2;
        }
        return wrong;
    }
}
