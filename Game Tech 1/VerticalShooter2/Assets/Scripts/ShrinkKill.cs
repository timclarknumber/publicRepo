using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkKill : MonoBehaviour
{
    public float shrinkLife = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shrinkLife -= 1 * Time.deltaTime;
        if (shrinkLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
