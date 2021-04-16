using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public float startSpawnTime = 10.0f;
    public float spawnTime = 5.0f;
    public GameObject enemy;
    public GameObject enemyBoss;


    private float countDownTimer = 5f;
    public int maxWaves = 5;


    public Text countdownText;
    private int waveNumber = 0;

    private Coroutine spawner = null;

    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        if(countDownTimer <= 0f)
        {
         //   StartCoroutine(Spawn());

           spawner = StartCoroutine(Spawn());
           countDownTimer = spawnTime;
        }
        countDownTimer -= Time.deltaTime;
        countdownText.text = Mathf.Floor(countDownTimer).ToString();
     
    }

    // Create an instance of the enemy prefab at the  selected spawn point's position and rotation.
    IEnumerator Spawn()
    {
        for(int i = 0; i < waveNumber; i++)           
        {
            if(waveNumber > maxWaves)
            {
                yield break;
            }
            else if (waveNumber == maxWaves)
            {
                Instantiate(enemyBoss, new Vector3(-14, 0.05f, -13), transform.rotation);
                waveNumber++;
                yield break;                    
            }
            else if (waveNumber < maxWaves)
            {
                Instantiate(enemy, new Vector3(-14, 0.05f, -13), transform.rotation);
                yield return new WaitForSeconds(0.5f);
            }
        }
      //  FindObjectOfType<GameOverController>().endGame();

        waveNumber++;
        Debug.Log(waveNumber);
    }
}
