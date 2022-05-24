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

    [SerializeField] AudioSource typingSound;

    bool flag=true;

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

    public void ChangeText(string NewText,string AnimationString){
        StartCoroutine(WaitFunction(NewText,AnimationString));
    }

    IEnumerator WaitFunction(string NewText,string AnimationString)
    {
        if(flag){
            flag=false;
            animator.ChangeAnimationState(AnimationString);
            string[] words = NewText.Split(' ');
            mainText.text="";
            foreach (var word in words)
            {
                if(!typingSound.isPlaying){
                    typingSound.Play();
                }
                mainText.text=mainText.text+" "+word;
                yield return new WaitForSeconds(0.2f);
            }
            typingSound.Stop();
            flag=true;
        }
    }

    public void TopLeftAction(){
        ChangeText("The museum was made on the 10th of May 2022, by Limnos, Bili, Velasco and Chaniotakis.","Talking");
	}
    public void TopRightAction(){
        ChangeText("There was a zombie apocalypse and we are the sole survivors.","Walking");
	}
    public void BotLeftAction(){
        ChangeText("My favorite art piece is Banana Man! He is the best!","Talking");
	}
    public void BotRightAction(){
        ChangeText("THEEEEREEEEEEEEE...","Charge");
	}
}
