using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{

    public float moveSpeed; //spd which balloon moves up

    public float upperBound; //threshold where balloon despawns

    private Balloon balloon; //Reference balloon gameobj

    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloon>();  //ttatching gameobject to variable "balloon"
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
            
        }
    }
}
