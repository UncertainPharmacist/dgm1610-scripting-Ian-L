using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //clicks till balloon pops
    public float scaleToIncrease = 0.10f; //inflates balloon by 10%


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        clickToPop -= 1;
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}

