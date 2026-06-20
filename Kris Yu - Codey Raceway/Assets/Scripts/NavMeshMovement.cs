using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = GameObject.FindWithTag("obstacles").transform.position;
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50f;
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
