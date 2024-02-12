using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHearts : MonoBehaviour
{
        public GameObject obstacle;
    public float spawnTime;
    public float timeBetweenSpawning;
    public float maxY;
    public float minY;
    public float timeVarianceRange;
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
            float variance = Random.Range(-timeVarianceRange, timeVarianceRange);
            spawnTime = Time.time + timeBetweenSpawning + variance;
        }
    }

    void Spawn()
    {
        float yPos = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(0, yPos, 0), transform.rotation);
    }
}
