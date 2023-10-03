using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Telemetry : MonoBehaviour
{    
    //where the file being written to is
    public static string path = "Assets/Resources/telemetry.csv";
    public static Telemetry singleton;
    public static float playerXMeasured = 0;
    public static float playerYMeasured = 0;
    private bool deliverySpeedTestOngoing = false;
    private bool pizzaPrepareTestOngoing = false;
    private float deliverySpeed = 0;
    private float pizzaPrepareSpeed = 0;
    public List<float> deliveries = new List<float>();
    public List<float> pizzasMadeTotal = new List<float>();
    void Awake()
    {
        singleton = this; //weird thing i stole from a class I took a year and a half ago, i kinda forgot what singletons do tbh
        deleteTelemetry(); //get rid of the previous telemetry txt.
        //Important, because of this, save telemetry txt in between sessions or data is lost.
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (deliverySpeedTestOngoing)
        {
            deliverySpeed += Time.deltaTime;
        }
        if (pizzaPrepareTestOngoing)
        {
            pizzaPrepareSpeed += Time.deltaTime;
        }
        //Debug.Log("Telemetry player x is:" + playerXMeasured.ToString());
    }

    public static void writeToFile(string Input) 
    {
        if (Input == null)
        {
            Input = "what";
        }
        UnityEditor.AssetDatabase.Refresh();
        //method from: https://support.unity.com/hc/en-us/articles/115000341143-How-do-I-read-and-write-data-from-a-text-file-#:~:text=text%20property.&text=Another%20way%20to%20read%20and,as%20a%20TextAsset%20in%20Unity.
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(Input);
        writer.Close();
        UnityEditor.AssetDatabase.Refresh();
    }

    public static void deleteTelemetry()
    { //method from: https://discussions.unity.com/t/how-to-delete-a-file-using-application-datapath/163771
        UnityEditor.AssetDatabase.Refresh();
        File.Delete (path);
        UnityEditor.AssetDatabase.Refresh();
    }

    public static void beginDeliverySpeedTest()
    {
        //spooky singleton magic
        singleton.deliverySpeed = 0;
        singleton.deliverySpeedTestOngoing = true;
    }
    public static void endDeliverySpeedTest()
    {
        //spooky singleton magic
        singleton.deliverySpeedTestOngoing = false;
        singleton.deliveries.Add(singleton.deliverySpeed);
        string message = "Delivery Time: " + singleton.deliverySpeed.ToString();
        Telemetry.writeToFile(message);
    }
    public static void beginPizzaPrepareTest()
    {
        singleton.pizzaPrepareSpeed = 0;
        singleton.pizzaPrepareTestOngoing = true;
    }
    public static void endPizzaPrepareTest()
    {
        //spooky singleton magic
        singleton.pizzaPrepareTestOngoing = false;
        singleton.pizzasMadeTotal.Add(singleton.pizzaPrepareSpeed);
        string message = "Pizza Prepare Time: " + singleton.pizzaPrepareSpeed.ToString();
        Telemetry.writeToFile(message);
    }

    public static float averageOfAll(List<float> listToBeAveraged)
    {
        float average = 0;
        for (int i = 0; i < listToBeAveraged.Count; i++)
        {
            average += listToBeAveraged[i];
        }
        average = average / listToBeAveraged.Count; 
        return average;
    }
}
