using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        if (transform.position.x <= -8 || transform.position.x >= 8)
        {
            speed *= -1;
        }
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
