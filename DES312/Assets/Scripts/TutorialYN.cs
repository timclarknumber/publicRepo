using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialYN : MonoBehaviour
{
    public bool YN;
    // Start is called before the first frame update
    void Awake()
    {
        Telemetry.TutorialYN(YN);
    }

    // Update is called once per frame

}
