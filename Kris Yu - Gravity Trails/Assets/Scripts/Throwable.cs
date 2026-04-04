using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;

            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwableCounter -= 1;
        }
    }
}
