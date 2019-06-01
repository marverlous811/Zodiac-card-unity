using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class CardObject{
    public string name {get; set;}
    public string type {get; set;}
    public int[] values {get; set;}

    public string[] listZodiac {get; set;}
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

    public CardObject mars{get; set;}
    public CardObject venus{get; set;}
    public CardObject mercury{get; set;}
    public CardObject moon{get; set;}
    public CardObject sun{get; set;}
    public CardObject pluto{get; set;}
    public CardObject jupiter{get; set;}
    public CardObject saturn{get; set;}
    public CardObject uranus{get; set;}
    public CardObject neptune{get; set;}
    public CardObject judgement{get; set;}
    public CardObject the_world {get; set;}
}