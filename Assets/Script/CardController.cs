using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField] private GameObject Card_Back;
    private Card _card;
    private bool reavealed = false;

    public Card info{
        set{
            _card = value;
            this.updateCardTexture();
        }
    }

    void updateCardTexture(){
        // Debug.Log(this._card.TexturePath);
        var rend = this.GetComponent<SpriteRenderer>();
        string path = "Card/"+_card.TexturePath;
        // Debug.Log(path);
        Texture t = Resources.Load(path) as Texture;
        // rend.material.mainTexture = t;
        rend.sprite = Sprite.Create((Texture2D)t, rend.sprite.rect, new Vector2(0.5f, 0.5f));
    }

    public void ReavealedCard(){
        this.reavealed = true;
        Card_Back.SetActive(false);
    }

}
