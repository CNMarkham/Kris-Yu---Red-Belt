using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        float newzPosition = -5;
        Vector3 newPosition = new Vector3(newXPosition, newYPosition, newzPosition);
        transform.position = newPosition;
    }
}
