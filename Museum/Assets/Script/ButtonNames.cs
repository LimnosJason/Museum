using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Button = UnityEngine.UI.Button;

public class ButtonNames : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextUp;
    [SerializeField] TextMeshProUGUI TextDown;
    [SerializeField] GameObject ButtonUp;
    [SerializeField] GameObject ButtonDown;

    MainButtons mainButtons;
    [SerializeField] GameObject talkingButtons;

    VideoScript videoScript;
    [SerializeField] GameObject video;

    AnimationManager animator;
    [SerializeField] GameObject animationObject;

    int numAction;
    void Awake(){
        videoScript = video.GetComponent<VideoScript>();
        mainButtons = talkingButtons.GetComponent<MainButtons>();
        animator = animationObject.GetComponent<AnimationManager>();
        DisableButtons();
    }

    public void EnableButtons(){
        ButtonUp.SetActive(true);
        ButtonDown.SetActive(true);
    }

    public void DisableButtons(){
        ButtonUp.SetActive(false);
        ButtonDown.SetActive(false);
    }
    
    public void ProjectRoom(){
        TextUp.text="Play (P)";
        TextDown.text="Pause (O)";
        numAction=0;
    }
    
    public void ArtWorkInteraction(){
        TextUp.text="Inspect (I)";
        TextDown.text="Put To Cart (B)";
        numAction=1;
    }
    
    public void CareTakerInteraction(){
        TextUp.text="Talk (T)";
        TextDown.text="Hello (H)";
        numAction=2;
    }

    public void ButtonUpActions(){
        switch(numAction){
            case 0:
                videoScript.PlayVideo();
                break;
            case 1:
                break;
            case 2:
                mainButtons.EnableButtons();
                break;
        }
	}

    public void ButtonDownActions(){
        switch(numAction){
            case 0:
                videoScript.PauseVideo();
                break;
            case 1:
                break;
            case 2:
                animator.ChangeAnimationState("Waving");
                break;
        }
	}
}
