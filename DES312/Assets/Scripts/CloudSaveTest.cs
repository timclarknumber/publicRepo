using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using System.IO;

public static class CloudSaveTest
{
    public static string key = "";
    // Start is called before the first frame update
    public async static void SaveIntialize()
    {
        await UnityServices.InitializeAsync();
        //await AuthenticationService.Instance.SignInAnonymouslyAsync(); //anonymous method
        //await AuthenticationService.Instance.SignUpWithUsernamePasswordAsync("exampleUsername2", "examplePassword2!"); //username password method signup
        await AuthenticationService.Instance.SignInWithUsernamePasswordAsync("exampleUsername2", "examplePassword2!"); //uesrname password method sign in;
        Telemetry.deleteTelemetry(); //get rid of the previous telemetry txt.

        ListPlayerFiles();

    }

    public async static void saveData()
    {
        //#if !UNITY_EDITOR
        //Stream fileStream await CloudSaveService.Instance.Files.Player.LoadStreamAsync("fileName.csv");

        byte[] file = System.IO.File.ReadAllBytes(Application.persistentDataPath + "/telemetry.csv");
        //SystemInfo.deviceName
        await CloudSaveService.Instance.Files.Player.SaveAsync(key, file,null);
        
        //DICTIONARY METHOD
        //var listOf = new List<string>();
        //listOf.Add("thing 1");
        //listOf.Add("bing 2");
        Debug.Log("HERE WE GO");
        //var data = new Dictionary<string, object>{ { "yay", listOf } };
        //await CloudSaveService.Instance.Data.ForceSaveAsync(data);
        //#endif
    }

    public async static void loadData()
    {
        //var fileStream = await LoadFileStream(streamFileKey);

    }

    public async static void ListPlayerFiles()
    {
        #if UNITY_EDITOR
        List<Unity.Services.CloudSave.Models.FileItem> files = await CloudSaveService.Instance.Files.Player.ListAllAsync();

        string key = "";
        foreach(Unity.Services.CloudSave.Models.FileItem f in files){
                Debug.Log(f.Key);
                key = f.Key; 
                
                var task = await CloudSaveService.Instance.Files.Player.LoadBytesAsync(key);
                System.IO.File.WriteAllBytes(key + ".csv", task);
        }

        #endif
        
       
        //for (int i = 0; i < files.Count; i++)
        //{
            //Debug.Log(files[i]);
        //}
    }

    public async static void setID(string localID)
    {
        key = localID;
    }
}
