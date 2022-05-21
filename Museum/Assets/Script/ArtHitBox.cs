using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtHitBox : MonoBehaviour
{
    ButtonNames buttonNames;
    [SerializeField] GameObject buttons;

    void Awake(){
        buttonNames = buttons.GetComponent<ButtonNames>();
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
    }
    void OnTriggerEnter(Collider other)
    {
        buttonNames.ArtWorkInteraction();
        buttonNames.EnableButtons();
    }
}
