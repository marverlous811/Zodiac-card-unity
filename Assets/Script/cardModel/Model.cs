using System;
using System.Collections;
using System.Collections.Generic;

public enum CARD_TYPE
{
    Zodiac = 1,
    Plannet   
}

[Serializable]
public class Card{
    protected string _name;
    protected int _value;
    protected CARD_TYPE _type = CARD_TYPE.Zodiac;

    protected string texturePath;

    public Card(string name, int value){
        this._name = name;
        this._value = value;
        this.texturePath = name+"_"+value;
    }

    public string name{
        get { return this._name; }
        set { this._name = value; } 
    }

    public int value{
        get { return this._value; }
        set { this._value = value; }
    }
}

public class ZodiacCard : Card{
    public ZodiacCard(string name, int value) : base(name, value){
        this._type = CARD_TYPE.Zodiac;
    }
}

public class PlannetCard : Card{
    protected string[] _listZodiac;
    public PlannetCard(string name, int value, string[] listZodiac) : base(name, value){
        this._type = CARD_TYPE.Plannet;
        this._listZodiac = listZodiac;
    }

    public string[] listZodiac{
        get{ return this._listZodiac; }
    }
}

public abstract class _CardFactory{
    public abstract Card createCard(string name, int value, string[] listCard);
}

public class ZodiacFactory : _CardFactory{
    public override Card createCard(string name, int value, string[] listCard){
        Card _card = new ZodiacCard(name, value);
        return _card;
    }
}

public class PlannetFactory : _CardFactory{
    public override Card createCard(string name, int value, string[] listCard){
        Card _card = new PlannetCard(name, value, listCard);
        return _card;
    }
}

public class CardFactory{
    public Dictionary<string, _CardFactory> factory = new Dictionary<string, _CardFactory>();
    public CardFactory(){
        this.factory.Add("Zodiac", new ZodiacFactory());
        this.factory.Add("Plannet", new PlannetFactory());
    }

    public Card addCard(string name, int value, string type, string[] listCard){
        Card _card = this.factory[type].createCard(name, value, listCard);
        return _card;
    }
}

[Serializable]
public class CardModel{
    protected List<Card> listCard = new List<Card>();
    protected CardFactory cardFactory = new CardFactory();

    public void addCard(CardObject cardObject){
        for(int i = 0; i < cardObject.values.Length; i++){
            Card card = this.cardFactory.addCard(
                cardObject.name, 
                cardObject.values[i], 
                cardObject.type, 
                cardObject.listZodiac
            );
            this.listCard.Add(card);
        }
    }

    public List<Card> list{
        get{ return this.listCard; }
    }
}