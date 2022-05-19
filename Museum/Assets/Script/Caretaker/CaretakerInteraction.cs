using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaretakerInteraction : MonoBehaviour
{
    ButtonNames buttonNames;
    [SerializeField] GameObject buttons;
    MainButtons mainButtons;
    [SerializeField] GameObject talkingButtons;

    void Awake(){
        buttonNames = buttons.GetComponent<ButtonNames>();
        mainButtons = talkingButtons.GetComponent<MainButtons>();
    }

    void OnTriggerExit(Collider other)
    {
        mainButtons.DisableButtons();
        buttonNames.DisableButtons();
    }
    void OnTriggerEnter(Collider other)
    {
        buttonNames.CareTakerInteraction();
        buttonNames.EnableButtons();
    }
}
