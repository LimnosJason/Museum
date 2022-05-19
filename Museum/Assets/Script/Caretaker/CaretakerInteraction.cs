using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaretakerInteraction : MonoBehaviour
{
    ButtonNames buttonNames;
    [SerializeField] GameObject buttons;
    MainButtons mainButtons;
    [SerializeField] GameObject talkingButtons;

    private bool talkingFlag=false;
    void Awake(){
        buttonNames = buttons.GetComponent<ButtonNames>();
        mainButtons = talkingButtons.GetComponent<MainButtons>();
    }
    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.T)){
                mainButtons.ChangeText("Ask me anything!");
                talkingFlag=true;
                buttonNames.ButtonUpActions();
            }
            else if(Input.GetKeyDown(KeyCode.H)){
                buttonNames.ButtonDownActions();
            }
            else if(talkingFlag){
                if(Input.GetKeyDown(KeyCode.Alpha1)){
                    mainButtons.TopLeftAction();
                }
                else if(Input.GetKeyDown(KeyCode.Alpha2)){
                    mainButtons.TopRightAction();
                }
                else if(Input.GetKeyDown(KeyCode.Alpha3)){
                    mainButtons.BotLeftAction();
                }
                else if(Input.GetKeyDown(KeyCode.Alpha4)){
                    mainButtons.BotRightAction();
                }
            }
        }   
    }
    void OnTriggerExit(Collider other)
    {
        talkingFlag=false;
        mainButtons.DisableButtons();
        buttonNames.DisableButtons();
    }
    void OnTriggerEnter(Collider other)
    {
        buttonNames.CareTakerInteraction();
        buttonNames.EnableButtons();
    }
    
}
