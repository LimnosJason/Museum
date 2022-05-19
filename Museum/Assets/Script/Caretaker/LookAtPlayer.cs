using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    [SerializeField] Transform Player;
    [SerializeField] Transform ProjectRoomDoor;
    Animator animator;
    private string currentState;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }
    // Update is called once per frame
    void Update()
    {
        if(!animator.GetCurrentAnimatorStateInfo(0).IsName("Charge")){
            transform.LookAt(Player);
        }
        else{
            transform.LookAt(ProjectRoomDoor);
        }
        transform.rotation = Quaternion.Euler(0,transform.rotation.eulerAngles.y,0);
    }
}
