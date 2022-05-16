using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Awake(){
        videoPlayer= GetComponent<VideoPlayer>();
    }
    public void MuteVideo(){
        videoPlayer.SetDirectAudioMute(0,true);
    }
    public void UnMuteVideo(){
        videoPlayer.SetDirectAudioMute(0,false);
    }
    public void PlayVideo(){
        videoPlayer.Play();
    }
    public void PauseVideo(){
        videoPlayer.Pause();
    }
}
