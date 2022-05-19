using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainButtons : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mainText;

    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    [SerializeField] GameObject Button3;
    [SerializeField] GameObject Button4;
    [SerializeField] GameObject BackGround;

    AnimationManager animator;
    [SerializeField] GameObject animationObject;

    void Awake(){
        animator = animationObject.GetComponent<AnimationManager>();
        DisableButtons();
    }

    public void DisableButtons(){
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
        BackGround.SetActive(false);

    }

    public void EnableButtons(){
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
        Button4.SetActive(true);
        BackGround.SetActive(true);
    }

    public void ChangeText(string NewText){
        mainText.text=NewText;
    }
    public void TopLeftAction(){
        ChangeText("The museum was made on the 10th of May 2022, by Limnos, Bili, Velasko and Chaniotakis.");
        animator.ChangeAnimationState("Talking");
	}
    public void TopRightAction(){
        ChangeText("There was a zombie apocalypse and we are the sole survivors.");
        animator.ChangeAnimationState("Walking");
	}
    public void BotLeftAction(){
        ChangeText("My favorite art piece is Banana Man! He is the best!");
        animator.ChangeAnimationState("Talking");
	}
    public void BotRightAction(){
        ChangeText("THEEEEREEEEEEEEE...");
        animator.ChangeAnimationState("Charge");
	}
}
