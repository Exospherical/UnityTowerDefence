using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{

    private float shootTimer = 0.5f;
    private float shootTimerMax = 0.5f;

    public Transform target;
    public float range = 15f;
    public float turnSpeed = 10f;

    // Update is called once per frame

    public GameObject bulletPrefab;
    public Transform parttoRotate;

    public string enemyTag = "Enemy";

    void Start()
    {
        InvokeRepeating("updateTarget", 0f, 0.5f);
    }

    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion lookrotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(parttoRotate.rotation, lookrotation, Time.deltaTime * turnSpeed) .eulerAngles;
        parttoRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        shootTimer -= Time.deltaTime;
    }


    // void OnTriggerEnter(Collider co)
    void OnTriggerStay(Collider co)

    {
        if (shootTimer <= 0f)
        {
            shootTimer = shootTimerMax;

            // Was it a Monster? Then Shoot it
            if (co.GetComponent<MonsterScript>())
            {
            //    GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
             //   g.GetComponent<Bullet>().target = co.transform;
            }
        }



    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }


    void updateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistanceToEnemy = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistanceToEnemy)
            {
                shortestDistanceToEnemy = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistanceToEnemy <= range)
        {
            target = nearestEnemy.transform;
        }
        else { target = null; }

    }

}
