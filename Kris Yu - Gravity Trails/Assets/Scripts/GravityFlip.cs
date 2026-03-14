using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidBody;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidBody.gravityScale *= -1;
            Vector3 newDirection = transform.localScale;
            newDirection.y *= -1;
            transform.localScale = newDirection;
        }
    }
}
