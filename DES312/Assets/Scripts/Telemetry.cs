using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Telemetry : MonoBehaviour
{    
    //where the file being written to is
    //public static string path = Application.persistentDataPath + "/telemetry.csv";
    public static Telemetry singleton;
    public static float playerXMeasured = 0;
    public static float playerYMeasured = 0;
    private bool deliverySpeedTestOngoing = false;
    private bool pizzaPrepareTestOngoing = false;
    private bool highwayRideOngoing = false;
    private bool currentlyInTutorial = false;
    private float deliverySpeed = 0;
    private float pizzaPrepareSpeed = 0;
    private float highwayRideTime = 0;
    private float timeInTutorial = 0;
    public List<float> deliveries = new List<float>();
    public List<float> pizzasMadeTotal = new List<float>();
    public List<float> highwayRides = new List<float>();
    void Awake()
    {
        CloudSaveTest.SaveIntialize();
        singleton = this; //weird thing i stole from a class I took a year and a half ago, i kinda forgot what singletons do tbh
        deleteTelemetry(); //get rid of the previous telemetry txt.
        //Important, because of this, save telemetry txt in between sessions or data is lost.
    }

    // Start is called before the first frame update
    void Start()
    {
        //CloudSaveTest.ListPlayerFiles();
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
        if (highwayRideOngoing)
        {
            highwayRideTime += Time.deltaTime;
        }
        if (currentlyInTutorial)
        {
            timeInTutorial += Time.deltaTime;
        }
        //Debug.Log("Telemetry player x is:" + playerXMeasured.ToString());
    }

    public static void writeToFile(string Input) 
    {
        if (Input == null)
        {
            Input = "what";
        }
        string path = Application.persistentDataPath + "/telemetry.csv";
        //UnityEditor.AssetDatabase.Refresh();
        //method from: https://support.unity.com/hc/en-us/articles/115000341143-How-do-I-read-and-write-data-from-a-text-file-#:~:text=text%20property.&text=Another%20way%20to%20read%20and,as%20a%20TextAsset%20in%20Unity.
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(Input);
        writer.Close();
        //UnityEditor.AssetDatabase.Refresh();
        CloudSaveTest.saveData();
    }

    public static void deleteTelemetry()
    { //method from: https://discussions.unity.com/t/how-to-delete-a-file-using-application-datapath/163771
        //UnityEditor.AssetDatabase.Refresh();
        
        string path = Application.persistentDataPath + "/telemetry.csv";
        if (path != null)
        {
            File.Delete (path);
        }
        //UnityEditor.AssetDatabase.Refresh();
    }
    public static void TutorialYN(bool YN)
    {
        singleton.currentlyInTutorial = YN;
    }
    public static void WriteTutorialTime()
    {
        writeToFile("Time in tutorial: " + singleton.timeInTutorial.ToString());
    }

    public static void beginDeliverySpeedTest()
    {
        Debug.Log(singleton.currentlyInTutorial);
        if (!singleton.currentlyInTutorial)
        {
            //spooky singleton magic
            singleton.deliverySpeed = 0;
            singleton.deliverySpeedTestOngoing = true;
        }
    }
    public static void endDeliverySpeedTest()
    {
        if (!singleton.currentlyInTutorial)
        {
            //spooky singleton magic
            singleton.deliverySpeedTestOngoing = false;
            singleton.deliveries.Add(singleton.deliverySpeed);
            string message = "Delivery Time: " + singleton.deliverySpeed.ToString();
            Telemetry.writeToFile(message);
        }
    }
    public static void beginPizzaPrepareTest()
    {
        if (!singleton.currentlyInTutorial)
        { 
            singleton.pizzaPrepareSpeed = 0;
            singleton.pizzaPrepareTestOngoing = true;
        }
    }
    public static void endPizzaPrepareTest()
    {

        if (!singleton.currentlyInTutorial)
        {
            //spooky singleton magic
            singleton.pizzaPrepareTestOngoing = false;
            singleton.pizzasMadeTotal.Add(singleton.pizzaPrepareSpeed);
            string message = "Pizza Prepare Time: " + singleton.pizzaPrepareSpeed.ToString();
            Telemetry.writeToFile(message);
        }
    }
    public static void enterHighway()
    {       
        if (!singleton.currentlyInTutorial)
        {
            singleton.highwayRideTime = 0;
            singleton.highwayRideOngoing = true;
        }
    }
    public static void exitHighway()
    {
        if (!singleton.currentlyInTutorial)
        {
            //spooky singleton magic
            singleton.highwayRideOngoing = false;
            if (singleton.highwayRideTime > 0.7) //excluding times they hop on and then immediately back off
            {
                singleton.highwayRides.Add(singleton.highwayRideTime);
            }
            string message = "Highway ride time: " + singleton.highwayRideTime.ToString();
            Telemetry.writeToFile(message);
        }
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
