using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public Transform[] spawns;
    public GameObject[] meteors;

    private float spawnTime = 4f;
    private float delay;
    private int randomMeteors;
    private int randomSpawns;

    void Start()
    {
        GiveRandomNumbers();
    }
   
    void Update()
    {
        SpawnMeteors();
    }

    private void SpawnMeteors()
    {
        delay += Time.deltaTime;

        if (delay >= spawnTime)
        {
            Instantiate(meteors[randomMeteors], spawns[randomSpawns]);
            delay = 0;

            GiveRandomNumbers();
        }
    }

    private void GiveRandomNumbers()
    {
        randomMeteors = Random.Range(0, 3);
        randomSpawns = Random.Range(0, 2);
    }
}
