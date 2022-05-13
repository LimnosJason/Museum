using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    OpenDoor openDoor;
    [SerializeField] GameObject DoorCheck;
    [SerializeField] Transform Floor;
    [SerializeField] Transform FloorCheck;
    [SerializeField] GameObject[] FloorWaypoints;

    void Awake(){
        openDoor = DoorCheck.GetComponent<OpenDoor>();
    }
    
    void Update()
    {

    }
}
