using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    private Transform target;

    public float speed = 30f;

    //public GameObject impactEffect;

    public float sphereRadius = 5f;
    public void Seek(Transform targetArg)
    {
        target = targetArg;
    }

    // Update is called once per frame
    void Update()
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
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        //GameObject effect = Instantiate(impactEffect, transform.position, transform.rotation);
        //Destroy(effect, 2.5f);

        Collider[] objectsHit = Physics.OverlapSphere(transform.position, sphereRadius);
        foreach(Collider objectHit in objectsHit)
        {
            if (target.GetComponent<EnemyHealth>() != null)
            {
                EnemyHealth health = target.GetComponent<EnemyHealth>();
                health.health -= 1;
                if (health.health <= 0)
                {
                    Destroy(target.gameObject);
                }
            }
            
        }
        Destroy(gameObject);
    }
}
