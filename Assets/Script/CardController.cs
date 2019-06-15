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
        var rend = this.GetComponent<SpriteRenderer>();
        rend.sprite = Sprite.Create(this._card.Texture(), rend.sprite.rect, new Vector2(0.5f, 0.5f));
    }

    public void ReavealedCard(){
        this.reavealed = true;
        Card_Back.SetActive(false);
    }

}
