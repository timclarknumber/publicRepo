using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField]private Transform thisTransform;
    [SerializeField]private float maxGrow = 3;
    [SerializeField]private float growRate = 2;
    private float startSize;

    // Update is called once per frame
    void Start()
    {
        startSize = thisTransform.localScale.x;
    }

    void Update()
    {
        if (thisTransform.localScale.x >= startSize * maxGrow)
        {
            Destroy(gameObject);
        }
        thisTransform.localScale = new Vector3(thisTransform.localScale.x + Time.deltaTime * growRate, thisTransform.localScale.x + Time.deltaTime * growRate, thisTransform.localScale.x + Time.deltaTime);
    }
}
