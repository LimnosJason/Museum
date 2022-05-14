using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    OpenDoor openDoorDown;
    OpenDoor openDoorUp;
    [SerializeField] GameObject DoorCheckDown;
    [SerializeField] GameObject DoorCheckUp;
    [SerializeField] Transform Floor;
    [SerializeField] Transform OtherFloor;
    [SerializeField] Transform Roof;
    [SerializeField] Transform OtherRoof;
    [SerializeField] float speed = 1f;
    [SerializeField] GameObject[] FloorWaypoints;
    [SerializeField] GameObject[] OtherFloorWaypoints;
    [SerializeField] GameObject[] RoofWaypoints;
    [SerializeField] GameObject[] OtherRoofWaypoints;
    public int openDoorFlag= -1;
    int pos = 0;
    void Awake(){
        openDoorDown = DoorCheckDown.GetComponent<OpenDoor>();
        openDoorUp = DoorCheckUp.GetComponent<OpenDoor>();
    }
    private void OnTriggerEnter(Collider other){
        if(Vector3.Distance(Floor.position, FloorWaypoints[pos].transform.position) < .1f){
            pos++;
            if(pos >= FloorWaypoints.Length){
                pos=0;
            }
        }
    }
    private void OnTriggerExit(Collider other){
        openDoorFlag=-1;
    }
    private void OnTriggerStay(Collider other){
        if(openDoorDown.closedDoor && openDoorUp.closedDoor){
            if(Vector3.Distance(Floor.position, FloorWaypoints[pos].transform.position) > .1f){
                Floor.position = Vector3.MoveTowards(Floor.position, FloorWaypoints[pos].transform.position, speed*Time.deltaTime);
                Roof.position = Vector3.MoveTowards(Roof.position, RoofWaypoints[pos].transform.position, speed*Time.deltaTime);

                OtherFloor.position = Vector3.MoveTowards(OtherFloor.position, OtherFloorWaypoints[pos].transform.position, speed*Time.deltaTime);
                OtherRoof.position = Vector3.MoveTowards(OtherRoof.position, OtherRoofWaypoints[pos].transform.position, speed*Time.deltaTime);
            }
            else{
                openDoorFlag= pos;
            }
        }
    }

}
