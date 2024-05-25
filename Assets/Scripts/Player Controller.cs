using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float normalSpeed = 10f;
    [SerializeField] float boostSpeed = 20f;
    Rigidbody2D rigidbody;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    private void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }
    void Update(){
        if (canMove){
        RotatePlayer();
        RespondToBoost();
        }
    }

    public void DisableControls(){
           canMove = false;
    }
    void RespondToBoost(){
         if(Input.GetKey(KeyCode.W)){
            surfaceEffector2D.speed = boostSpeed;
        } else {
            surfaceEffector2D.speed= normalSpeed;
        }
    }
    void RotatePlayer() {
        if(Input.GetKey(KeyCode.A)){
            rigidbody.AddTorque(torqueAmount);
        } else if(Input.GetKey(KeyCode.D)){
            rigidbody.AddTorque(-torqueAmount);
        }
    }
}
