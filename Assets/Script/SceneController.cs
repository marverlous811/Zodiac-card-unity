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

    public const int maxRow = 9;

    public const int maxColumn = 2;

    public int nowRow = 0;
    public int nowColumn = 0;

    public const float offsetX = 2f;
    public const float offsetY = 3f;

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
        nowRow++;
        if(nowRow >= maxRow){
            nowRow = 1;
            nowColumn++;
        }
        float posX = (offsetX * nowRow) + startPos.x;
        float posY = (offsetY * nowColumn) - startPos.y;
        card.transform.position = new Vector3(posX, posY, startPos.z); 
        card.ReavealedCard();

        nowIndex++;
    }
}
