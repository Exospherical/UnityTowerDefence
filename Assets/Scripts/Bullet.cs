using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;


    // Target (set by Tower)
    public Transform target;

    void FixedUpdate()
    {
        if (target)
        {
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void chase(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            hitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);



    }

    void hitTarget()
    {

    }

    void OnTriggerEnter(Collider co)
    {
        HealthBar health = co.GetComponentInChildren<HealthBar>();
        if (health)
        {
            health.decrease();
            Destroy(gameObject);
        }
    }
}
