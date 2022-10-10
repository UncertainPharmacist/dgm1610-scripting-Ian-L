using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public int upperbound =20;
    public int lowerbound =-10;

  

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperbound)
        {
            Destroy(gameObject);
        }

       else if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
    }
}
