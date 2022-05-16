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
                Debug.Log("dwa");
                videoScript.PlayPause();
            }
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
