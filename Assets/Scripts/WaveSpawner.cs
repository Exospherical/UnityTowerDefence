using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public int startSpawnTime = 5;
    public int spawnTime = 5;
    public GameObject enemy;
    private int time = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startSpawnTime, spawnTime);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
       
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, new Vector3(-14, 0.05f, -13), transform.rotation);
    }
}
