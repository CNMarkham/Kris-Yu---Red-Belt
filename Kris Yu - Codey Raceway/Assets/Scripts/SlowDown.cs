using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public float Speed = 15f;

    IEnumerator Start()
    {
        Speed = 1f;
        yield return new WaitForSeconds(5f);
        RegularSpeed();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    void RegularSpeed()
    {
        Speed = 15f;
    }
}
