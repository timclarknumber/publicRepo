using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLower : MonoBehaviour
{
    
    [SerializeField]private RectTransform thisTransform;

    public void lowerHealthBy(float damage)
    {
        thisTransform.localScale = new Vector3(thisTransform.localScale.x - (damage / 100f), thisTransform.localScale.y, thisTransform.localScale.z);
    }
}
