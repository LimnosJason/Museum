using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    bool flag=false;
    void Awake(){
        videoPlayer= GetComponent<VideoPlayer>();
    }

    public void PlayPause(){
        if(flag){
            flag=false;
            videoPlayer.Pause();
        }
        else{
            Debug.Log("awda");
            flag=true;
            videoPlayer.Play();
        }
    }
}
