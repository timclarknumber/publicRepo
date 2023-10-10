using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    // Start is called before the first frame update
    public static void MoveToNextScene()
    {
        Telemetry.writeToFile("Average of all Delivery Times: " + Telemetry.averageOfAll(Telemetry.singleton.deliveries).ToString());
        Telemetry.writeToFile("Average of all Pizza Preparing Times: " + Telemetry.averageOfAll(Telemetry.singleton.pizzasMadeTotal).ToString());
        Telemetry.writeToFile("Average of all Highway Rides: " + Telemetry.averageOfAll(Telemetry.singleton.highwayRides).ToString());
        SceneManager.LoadScene("NoTime");
    }
}
