using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using Newtonsoft.Json; 

public class SceneController : MonoBehaviour
{
    private CardModel cardModel = new CardModel();
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

            foreach(var temp in cardObject.GetType().GetProperties()){
                object val = temp.GetValue(cardObject);
                cardModel.addCard((CardObject)val);
            }

            // Debug.Log(cardModel.list.Count);
        }
        else{
            Debug.LogError("Cannot load game data");
        }
    }
}
