using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController : MonoBehaviour
{

    //public variables
    public float speed = 0; 

    // private variables 
    private Rigidbody rb;
    private float movementX;
    private float movementY;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        Debug.Log("hello"); 
    }
    public void OnMove(InputValue movementValue)
    {
        Debug.Log("onMove"); 
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        movementX = movementVector.x;
        movementY = movementVector.y;
        Debug.Log(movementX);
        Debug.Log(movementY); 

    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate"); 
        // Vector3 is a 3D vector or point (X, Z, Y) ??? that doesn't seem quite right
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); 
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);  
    }



}
