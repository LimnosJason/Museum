using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFirstDoors : MonoBehaviour
{
    OpenFirstDoors openFirstDoors;
    [SerializeField] GameObject openDoorCheck;
    [SerializeField] Transform LeftDoor;
    [SerializeField] Transform RightDoor;
    [SerializeField] float doorSpeed = 40f;
    bool flag=false;

    void Awake(){
        openFirstDoors = openDoorCheck.GetComponent<OpenFirstDoors>();
    }

    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(gameObject.name.Contains("front")){
                if(LeftDoor.transform.localRotation.eulerAngles.y>90){
                    LeftDoor.Rotate(0,-(doorSpeed * Time.deltaTime),0);
                    RightDoor.Rotate(0,(doorSpeed * Time.deltaTime),0);
                    openFirstDoors.flag=true;
                    flag=true;
                }
            }
            else{
                if(LeftDoor.transform.localRotation.eulerAngles.y<270){
                    LeftDoor.Rotate(0,(doorSpeed * Time.deltaTime),0);
                    RightDoor.Rotate(0,-(doorSpeed * Time.deltaTime),0);
                    openFirstDoors.flag=true;
                    flag=true;
                }
            }
        }   
    }

    void OnTriggerExit(Collider other)
    {
        openFirstDoors.flag=false;
        flag=false;
    }

    void Update()
    {
        if(!flag){
            if(LeftDoor.transform.localRotation.eulerAngles.y<175){
                LeftDoor.Rotate(0,(doorSpeed * Time.deltaTime),0);
                RightDoor.Rotate(0,-(doorSpeed * Time.deltaTime),0);
            }
            else if(LeftDoor.transform.localRotation.eulerAngles.y>185){
                LeftDoor.Rotate(0,-(doorSpeed * Time.deltaTime),0);
                RightDoor.Rotate(0,(doorSpeed * Time.deltaTime),0);
            }
        }
    }
}
