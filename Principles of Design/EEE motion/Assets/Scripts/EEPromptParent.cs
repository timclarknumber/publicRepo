using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EEPromptParent : MonoBehaviour
{
    [SerializeField]private Transform thisTransform;

    public void playerCanSeeMe()
    {
        thisTransform.position = new Vector3(365f,320f,0f);
    }

    public void doneWithThisPrompt()
    {
        Destroy(gameObject);
    }
}
