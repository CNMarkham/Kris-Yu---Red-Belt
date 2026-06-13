using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
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
