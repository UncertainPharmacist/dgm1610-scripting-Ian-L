using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Stats
    public float speed = 10f;
    public float rotSpeed = 50f;

    public Rigidbody playerRb;
   
    //Input Variables
     float hInput;

     float vInput;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get keyboard inputs
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        //Movement backwards and forwards
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);
        //Rotation left and right
        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime);

    }
}
