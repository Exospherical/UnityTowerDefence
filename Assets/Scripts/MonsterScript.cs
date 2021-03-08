﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GameObject castle = GameObject.Find("Tower_b");
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }

    void OnTriggerEnter(Collider co)
    {
        // If castle then deal Damage, destroy self
        if (co.name == "Castle")
        {
            co.GetComponentInChildren<HealthBar>().decrease();
            Destroy(gameObject);
        }
    }
}

   
