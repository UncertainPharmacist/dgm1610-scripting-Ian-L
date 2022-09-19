using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //clicks till balloon pops
    public float scaleToIncrease = 0.10f; //inflates balloon by 10%
    public int scoreToGive = 100;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Gameobject
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        clickToPop -= 1;
        
        transform.localScale += Vector3.one * scaleToIncrease; //Inflate balloon when clicked
        //Check to see if clickToPop has reached zero. If it has then pop balloon
        if(clickToPop == 0)
        {
            //Send points to score manager and update the score
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}

