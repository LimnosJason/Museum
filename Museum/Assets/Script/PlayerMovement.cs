using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 8f;
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Awake() {
        QualitySettings. vSyncCount = 1;
        Application. targetFrameRate = 30;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput ;
        controller.Move(move*movementSpeed*Time.deltaTime);

    }

}
