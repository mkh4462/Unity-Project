using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;

    private float timeBtwSpawn;
    public float startTimebtwSpawn;

    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if(timeBtwSpawn <=0)
        {
            int rand = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimebtwSpawn;
            if(startTimebtwSpawn > minTime){
                startTimebtwSpawn -= decreaseTime;

            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
