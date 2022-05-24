using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorHitBox : MonoBehaviour
{
    VideoScript videoScript;
    [SerializeField] GameObject video;

    ButtonNames buttonNames;
    [SerializeField] GameObject buttons;

    AnimationManager animator;
    [SerializeField] GameObject animationObject;
    void Awake(){
        videoScript = video.GetComponent<VideoScript>();
        buttonNames = buttons.GetComponent<ButtonNames>();
        animator = animationObject.GetComponent<AnimationManager>();
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.P)){
                videoScript.PlayVideo();
            }
            else if(Input.GetKeyDown(KeyCode.O)){
                videoScript.PauseVideo();
            }
            if(videoScript.Playing()){
                animator.ChangeAnimationState("Dancing Maraschino Step");
            }
        }   
    }

    void OnTriggerExit(Collider other)
    {
        buttonNames.DisableButtons();
        videoScript.MuteVideo();
    }
    void OnTriggerEnter(Collider other)
    {
        buttonNames.ProjectRoom();
        buttonNames.EnableButtons();
        videoScript.UnMuteVideo();
    }
}
