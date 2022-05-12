using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer:MonoBehaviour {
    public float speed = 150f;
    private float X;
    private float Y;
    public Transform playerBody;
    float xRotation = 0f;
    void Update() {
        if(Input.GetMouseButton(1)) {
            Cursor.lockState=CursorLockMode.Locked;
            X = Input.GetAxis("Mouse X") * speed*Time.deltaTime;
            Y = Input.GetAxis("Mouse Y") * speed*Time.deltaTime;
            xRotation -= Y;

            xRotation = Mathf.Clamp(xRotation, -90f, 45f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up*X);
        }
        else{
            Cursor.lockState=CursorLockMode.None;
        }
        
    }
}