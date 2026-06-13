using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshMovement : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        Transform closestTarget = GameObject.FindGameObjectsWithTag("obstacles")[0].transform;

        if (closestTarget != null)
        {
            agent.SetDestination(closestTarget.position);
        }

        Transform gameOverTarget = GameObject.FindGameObjectsWithTag("obstacles")[0].transform;
        Transform bestTarget = null;
        float closestDistance = Mathf.Infinity;
        Vector3 currentPosition = transform.position;

        foreach (GameObject potentialTarget in GameObject.FindGameObjectsWithTag("obstacles"))
        {
            Vector3 directionToTarget = potentialTarget.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;

            if (dSqrToTarget < closestDistance)
            {
                closestDistance = dSqrToTarget;
                bestTarget = potentialTarget.transform;
            }
        }

        if (bestTarget != null)
        {
            agent.SetDestination(bestTarget.position);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
