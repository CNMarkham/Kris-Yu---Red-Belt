using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public float Speed = 15f;

    void Start()
    {
        Speed = 2f;
        RegularSpeed();
    }

    void RegularSpeed()
    {
        Speed = 15f;
    }
}
