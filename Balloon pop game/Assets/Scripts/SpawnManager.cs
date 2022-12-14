using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{



    public GameObject[] balloonPrefabs;

    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {

        //Spawn range of balloons
        Vector3 spawnPosX = new Vector3(Random.Range(-xRange, xRange), 0, 0);

        //Pick Random balloon from balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        //Spawn a random balloon at spawn point
        Instantiate(balloonPrefabs[balloonIndex], spawnPosX, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
