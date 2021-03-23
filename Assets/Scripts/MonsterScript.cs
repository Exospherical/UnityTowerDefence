using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonsterScript : MonoBehaviour
{
    // public GameObject endGameController;
    



    // Start is called before the first frame update
    void Start()
    {

        GameObject castle = GameObject.Find("Door_a");
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }

    void OnTriggerEnter(Collider co)
    {
        // If castle then deal Damage, destroy self
        if (co.name == "Door_a")
        {
            // co.GetComponentInChildren<HealthBar>().decrease();
            Destroy(gameObject);
            FindObjectOfType<GameOverController>().endGame();


        }
    }




}

   

