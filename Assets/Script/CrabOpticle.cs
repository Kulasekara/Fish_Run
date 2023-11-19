using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabOpticle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenSpawn;
    private float spawntime;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 10) * Time.deltaTime);
        if(Time.time > spawntime)
        {
       Spawn();
       spawntime=Time.time +timebetweenSpawn;
       
    }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);

        Instantiate(obstacle,transform.position + new Vector3(randomX, randomY,0), transform.rotation);
    }
}
