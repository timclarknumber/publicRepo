using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLower : MonoBehaviour
{
    
    [SerializeField]private RectTransform thisTransform;
    [SerializeField]private float damageReductionRate = 100f;
    [SerializeField]private float healthUpgradeRate = 20f;

    public void lowerHealthBy(float damage)
    {
        thisTransform.localScale = new Vector3(thisTransform.localScale.x - (damage / damageReductionRate), thisTransform.localScale.y, thisTransform.localScale.z);
    }

    public void upgradePlayerHealth()
    {
        damageReductionRate += healthUpgradeRate;
    }
}
