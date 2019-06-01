using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class CardObject{
    public string name {get; set;}
    public string type {get; set;}
    public int[] values {get; set;}
}

[Serializable]
public class RootObject{
    public CardObject aries{get; set;}
    public CardObject taurus{get; set;}
    public CardObject gemini{get; set;}
    public CardObject cancer{get; set;}
    public CardObject leo{get; set;}
    public CardObject virgo{get; set;}
    public CardObject libra{get; set;}

    public CardObject scorpio{get; set;}
    public CardObject sagittarius{get; set;}
    public CardObject capricorn{get; set;}
    public CardObject aquarius{get; set;}
    public CardObject pisces{get; set;}
}