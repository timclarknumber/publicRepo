using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note that since Unity 2018.3 one should NOT attach a public static class to any instanced object!
// instead, the class only needs to exist in the runtime.
// notice that this class does NOT inherit from MonoBehavior

public static class Health
{
    public static int curentPlayerHealth = 4;
    public static int maxPlayerHealth = 4;
}
