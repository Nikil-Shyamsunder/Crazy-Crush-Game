using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class SpawnObstacles : MonoBehaviour
{
    public float timeBetweenSpawning;
    public float varianceRange;
    public GameObject obstacle;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            float variance = Random.Range(-varianceRange, varianceRange);
            spawnTime = Time.time + timeBetweenSpawning + variance;
        }
    }

    void Spawn()
    {
        Instantiate(obstacle, transform.position, transform.rotation);
    }
}
