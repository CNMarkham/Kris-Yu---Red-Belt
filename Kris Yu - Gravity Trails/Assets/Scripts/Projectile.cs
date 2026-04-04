using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    public float speed;
    private Throwable direction;

    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }

    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
}
