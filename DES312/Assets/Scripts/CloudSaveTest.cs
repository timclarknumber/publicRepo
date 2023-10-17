using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using System.IO;

public static class CloudSaveTest
{
    // Start is called before the first frame update
    public async static void SaveIntialize()
    {
        await UnityServices.InitializeAsync();
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    public async static void saveData()
    {
        //Stream fileStream await CloudSaveService.Instance.Files.Player.LoadStreamAsync("fileName.csv");

        byte[] file = System.IO.File.ReadAllBytes("Assets/Resources/telemetry.csv");
        await CloudSaveService.Instance.Files.Player.SaveAsync("hiya", file,null);
        //DICTIONARY METHOD
        //var listOf = new List<string>();
        //listOf.Add("thing 1");
        //listOf.Add("bing 2");
        Debug.Log("HERE WE GO");
        //var data = new Dictionary<string, object>{ { "yay", listOf } };
        //await CloudSaveService.Instance.Data.ForceSaveAsync(data);
    }

    public async static void loadData()
    {
        //var fileStream = await LoadFileStream(streamFileKey);

    }

    public async static void ListPlayerFiles()
    {
        //List<string> files = await CloudSaveService.Instance.Files.Player.ListAllAsync();

        //for (int i = 0; i < files.Count; i++)
        //{
            //Debug.Log(files[i]);
        //}
    }
}
