using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{

    public float fireRate = 1f;
    public float fireCountdown = 0f;

    public Transform target;
    public float range = 5f;
    public float turnSpeed = 10f;

    // Update is called once per frame

    public GameObject bulletPrefab;
    public Transform parttoRotate;

    public Transform firePoint;

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

        if (fireCountdown <= 0f)
        {
            shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
    }



    void shoot()
    {
       GameObject bulletGO =  (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.chase(target);

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
