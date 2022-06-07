using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtHitBox : MonoBehaviour
{
    ButtonNames buttonNames;
    [SerializeField] GameObject buttons;

    [SerializeField] GameObject itemText; 

    InspectItem inspectItem;
    [SerializeField] GameObject inspect;

    BuyItem buyItem;
    [SerializeField] GameObject _buyGameObject;
    [SerializeField] string _artName;
    [SerializeField] int _artPrice;

    void Awake(){
        buttonNames = buttons.GetComponent<ButtonNames>();
        inspectItem = inspect.GetComponent<InspectItem>();
        buyItem = _buyGameObject.GetComponent<BuyItem>();
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.I)){
                buttonNames.ButtonUpActions();
            }
            else if(Input.GetKeyDown(KeyCode.B)){
                buttonNames.ButtonDownActions();
            }
        }   
    }
    void OnTriggerExit(Collider other)
    {
        buttonNames.DisableButtons();
        inspectItem.DisableCanvas();
    }
    void OnTriggerEnter(Collider other)
    {
        buyItem.setItemName(_artName);
        buyItem.setItemPrice(_artPrice);
        getTextItem();
        buttonNames.ArtWorkInteraction();
        buttonNames.EnableButtons();
    }

    public void getTextItem(){
        inspectItem.GetText(itemText);
    }
}
