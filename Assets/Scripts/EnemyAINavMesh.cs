using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAINavMesh : MonoBehaviour
{
    [SerializeField] private Transform posTransform;
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = posTransform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.CompareTag("Enemy"))
        {
            GameControl.health = GameControl.health - 20;
            Destroy(this.gameObject);
            Debug.Log(GameControl.health);
        }
    }

}
