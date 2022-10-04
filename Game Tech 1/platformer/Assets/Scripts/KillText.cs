using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillText : MonoBehaviour
{
    [SerializeField] private float TimeToLive = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToLive -= 1 * Time.deltaTime;
        if (TimeToLive < 0)
        {
            Destroy(gameObject);
        }
    }
}
