using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    OpenDoor openDoor;
    [SerializeField] GameObject DoorCheck;
    [SerializeField] Transform Floor;
    [SerializeField] float speed = 1f;
    [SerializeField] GameObject[] FloorWaypoints;

    int pos = 0;
    void Awake(){
        openDoor = DoorCheck.GetComponent<OpenDoor>();
    }
    
    private void OnTriggerStay(Collider other){
        if(openDoor.closedDoor){
            if(Vector3.Distance(Floor.position, FloorWaypoints[pos].transform.position) < .1f){
                pos++;
                if(pos >= FloorWaypoints.Length){
                    pos=0;
                }
            }
            
            Floor.position = Vector3.MoveTowards(Floor.position, FloorWaypoints[pos].transform.position, speed*Time.deltaTime);
        }
    }

}
