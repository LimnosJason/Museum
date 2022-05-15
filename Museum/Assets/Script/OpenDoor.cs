using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    FloorMovement floorMovement;
    [SerializeField] GameObject ElevatorFloor;
    [SerializeField] Transform LeftDoor;
    [SerializeField] Transform RightDoor;
    [SerializeField] GameObject[] leftDoorWaypoints;
    [SerializeField] GameObject[] rightDoorWaypoints;
    [SerializeField] int Floor=0;

    public bool closedDoor=true;
    bool playerFlag=false;

    void Awake(){
        floorMovement = ElevatorFloor.GetComponent<FloorMovement>();
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            LeftDoor.position = Vector3.MoveTowards(LeftDoor.position, leftDoorWaypoints[1].transform.position,1f * Time.deltaTime);
            RightDoor.position = Vector3.MoveTowards(RightDoor.position, rightDoorWaypoints[1].transform.position,1f * Time.deltaTime);
            closedDoor=false;
            playerFlag=true;
        }   
    }

    void OnTriggerExit(Collider other)
    {
        playerFlag=false;
    }
    
    void Update(){
        if(floorMovement.openDoorFlag==Floor){
            LeftDoor.position = Vector3.MoveTowards(LeftDoor.position, leftDoorWaypoints[1].transform.position,1f * Time.deltaTime);
            RightDoor.position = Vector3.MoveTowards(RightDoor.position, rightDoorWaypoints[1].transform.position,1f * Time.deltaTime);
        }
        else if(!closedDoor&&!playerFlag){
            LeftDoor.position = Vector3.MoveTowards(LeftDoor.position, leftDoorWaypoints[0].transform.position,1f * Time.deltaTime);
            RightDoor.position = Vector3.MoveTowards(RightDoor.position, rightDoorWaypoints[0].transform.position,1f * Time.deltaTime);
            
            if(Vector3.Distance(LeftDoor.position,leftDoorWaypoints[0].transform.position)< .00001f){
                closedDoor=true;
            }
        }
    }
}
