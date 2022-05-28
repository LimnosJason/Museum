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

    void Awake(){
        buttonNames = buttons.GetComponent<ButtonNames>();
        inspectItem = inspect.GetComponent<InspectItem>();
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
        getTextItem();
        buttonNames.ArtWorkInteraction();
        buttonNames.EnableButtons();
    }

    public void getTextItem(){
        inspectItem.GetText(itemText);
    }
}
