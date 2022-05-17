using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorHitBox : MonoBehaviour
{
    VideoScript videoScript;
    [SerializeField] GameObject video;

    void Awake(){
        videoScript = video.GetComponent<VideoScript>();
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.P)){
                videoScript.PlayVideo();
            }
            else if(Input.GetKeyDown(KeyCode.O)){
                videoScript.PauseVideo();
            }
        }   
    }

    void OnTriggerExit(Collider other)
    {
        videoScript.MuteVideo();
    }
    void OnTriggerEnter(Collider other)
    {
        videoScript.UnMuteVideo();
    }
}
