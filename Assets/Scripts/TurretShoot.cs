using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{


    // Update is called once per frame

    public GameObject bulletPrefab;

    void Update()
    {
       

    }


    // void OnTriggerEnter(Collider co)
    void OnTriggerStay(Collider co)

    {

        // Was it a Monster? Then Shoot it
        if (co.GetComponent<MonsterScript>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = co.transform;
        }
    }


}
