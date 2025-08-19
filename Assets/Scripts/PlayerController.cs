using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro; 

public class PlayerController : MonoBehaviour
{

    //public variables
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject; 

    // private variables 
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false); 


        //Debug.Log("game start"); 
    }
    public void OnMove(InputValue movementValue)
    {
        //Debug.Log("onMove"); 
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        movementX = movementVector.x;
        movementY = movementVector.y;
        //Debug.Log(movementX);
        //Debug.Log(movementY); 

    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 45)
        {
            winTextObject.SetActive (true);
        }
    }

    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate"); 
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count += 5;
            SetCountText();
        }

        

    }



}
