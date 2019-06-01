using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    public void OnMouseDown(){
        controller.showTheCard();
    }
}
