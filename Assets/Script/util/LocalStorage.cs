using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LocalStorage{
    private static LocalStorage instance;
    private Dictionary<string, string> playerInfo;

    LocalStorage(){
        this.playerInfo = new Dictionary<string, string>();
    }
    public static LocalStorage getInstance(){
        if(instance == null){
            instance = new LocalStorage();
        }

        return instance;
    }

    public void setInfo(string key, string value){
        this.playerInfo.Add(key, value);
    }

    public string getInfo(string key){
        return this.playerInfo[key];
    }
}