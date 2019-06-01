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
    [SerializeField] private RootObject cardObject;
    [SerializeField] private CardController tempCard;

    public const float offsetX = 4f;
    public const float offsetY = 5f;

    private int nowIndex = 0;

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

    public void showTheCard(){
        Vector3 startPos = tempCard.transform.position;

        CardController card = Instantiate(tempCard) as CardController;
        card.info = cardModel.list[nowIndex];

        // int index = 1;
        float posX = (offsetX * 1) + startPos.x;
        float posY = (offsetY * 0) + startPos.y;
        card.transform.position = new Vector3(posX, posY, startPos.z); 
        card.ReavealedCard();

        nowIndex++;
    }
}
