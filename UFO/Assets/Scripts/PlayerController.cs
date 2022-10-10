using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float hInput;
    public float speed;
    public float xRange =8.45f;

    public GameObject laser;

    public Transform blaster;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);
        //right bound
        if (xRange<transform.position.x)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //left bound
        if (-xRange > transform.position.x)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, blaster.position, laser.transform.rotation);
        }


    }
}
