using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    [SerializeField]private Transform thisTransform;
    [SerializeField]private float shrinkrate = 0.01f;

    // Update is called once per frame
    void Update()
    {
        if (thisTransform.localScale.x <= 0.1)
        {
            Destroy(gameObject);
        }
        thisTransform.localScale = new Vector3(thisTransform.localScale.x - Time.deltaTime, thisTransform.localScale.x - Time.deltaTime, thisTransform.localScale.x - Time.deltaTime);
    }
}
