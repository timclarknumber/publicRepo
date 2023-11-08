using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Telemetry.writeToFile("Average of all Delivery Times: " + Telemetry.averageOfAll(Telemetry.singleton.deliveries).ToString());
        Telemetry.writeToFile("Average of all Pizza Preparing Times: " + Telemetry.averageOfAll(Telemetry.singleton.pizzasMadeTotal).ToString());
        Telemetry.writeToFile("Average of all Highway Rides: " + Telemetry.averageOfAll(Telemetry.singleton.highwayRides).ToString());
        Telemetry.printAllLevelMoneyTotals();
        Telemetry.WriteTutorialTime();
    }

}
