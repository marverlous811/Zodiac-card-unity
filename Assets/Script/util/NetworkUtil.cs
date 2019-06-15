using System.Collections;
using System.Collections.Generic;

public class NetworkUtil{
    private static NetworkUtil instance;
    public static NetworkUtil getInstance(){
        if(instance == null){
            instance = new NetworkUtil();
        }

        return instance;
    }

    public string buildQueryString(Dictionary<string, string> map){
        string temp = "";

        foreach(var pair in map){
            string key = pair.Key;
            string value = pair.Value;
            temp = temp + "&" + key + "=" + value; 
        }

        return temp;
    }
}