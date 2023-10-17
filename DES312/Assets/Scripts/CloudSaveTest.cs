using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;

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
        var listOf = new List<string>();
        listOf.Add("thing 1");
        listOf.Add("bing 2");
        Debug.Log("HERE WE GO");
        var data = new Dictionary<string, object>{ { "yay", listOf } };
        await CloudSaveService.Instance.Data.ForceSaveAsync(data);
    }

}
