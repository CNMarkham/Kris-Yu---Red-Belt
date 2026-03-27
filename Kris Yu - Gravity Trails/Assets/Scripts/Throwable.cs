using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire!"))
        {
            Instantiate(objectThrown, transform.position, transform.rotation);
        }
    }
}
