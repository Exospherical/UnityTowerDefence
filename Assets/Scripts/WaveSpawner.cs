using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public float startSpawnTime = 5.0f;
    public float spawnTime = 5.0f;
    public GameObject enemy;
    private int time = 1;

    private float countDownTimer = 5f;


    public Text countdownText;
    private int waveNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
    //    InvokeRepeating("Spawn", startSpawnTime, spawnTime);


    }

    // Update is called once per frame
    void Update()
    {
        if(countDownTimer <= 0f)
        {
            StartCoroutine(Spawn());
            countDownTimer = spawnTime;
        }

        countDownTimer -= Time.deltaTime;
        countdownText.text = Mathf.Floor(countDownTimer).ToString();

    }

    IEnumerator Spawn()
    {

        for(int i = 0; i < waveNumber; i++)
        {
            Instantiate(enemy, new Vector3(-14, 0.05f, -13), transform.rotation);
            yield return new WaitForSeconds(0.5f);

        }
        // Create an instance of the enemy prefab at the  selected spawn point's position and rotation.

        waveNumber++;

    }
}
