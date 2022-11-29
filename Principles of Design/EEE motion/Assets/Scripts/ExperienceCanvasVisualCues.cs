using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceCanvasVisualCues : MonoBehaviour
{
    [SerializeField]private GameObject UnlockedVisualCueObject;
    public void AbilityUnlockedVisual()
    {
        Instantiate(UnlockedVisualCueObject, new Vector3(0,0,0), Quaternion.identity);
    }
}
