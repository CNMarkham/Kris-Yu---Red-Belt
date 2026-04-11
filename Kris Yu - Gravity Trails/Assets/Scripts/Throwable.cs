using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter = 0;
    public Text collectableCounter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            throwableCounter += 1;
            collectableCounter.text = throwableCounter.ToString();
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
            collectableCounter.text = throwableCounter.ToString();
        }
    }
}
