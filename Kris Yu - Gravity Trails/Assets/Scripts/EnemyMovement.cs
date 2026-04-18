using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public int minimumPosition;
    public int maximumPosition;

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumPosition || transform.position.x >= maximumPosition)
        {
            speed *= -1;
        }
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        float newzPosition = -5;
        Vector3 newPosition = new Vector3(newXPosition, newYPosition, newzPosition);
        transform.position = newPosition;
    }
}
