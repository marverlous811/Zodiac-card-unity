using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json; 

public class SceneController : MonoBehaviour
{
    private string gameDatafileName = "card.json";
    [SerializeField]
    private RootObject cardObject;

    void Start(){
        loadGameData();
    }

    private void loadGameData(){
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDatafileName);
        if(File.Exists(filePath)){
            string dataAsJson = File.ReadAllText(filePath);
            RootObject cardObject = JsonConvert.DeserializeObject<RootObject>(dataAsJson);

            Debug.Log(cardObject.aries.name);
        }
        else{
            Debug.LogError("Cannot load game data");
        }
    }
}
