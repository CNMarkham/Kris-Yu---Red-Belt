using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointCollision : MonoBehaviour
{
    public bool didCollide; //true or false variable thingy
    public CheckpointCounter count;

    void Start()
    {
        didCollide = false; //at the start, set it to false
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && didCollide == false) //check if codey collided with the game object and if the didCollide variable is false
        {
            didCollide = true; //if both conditions are met, set didCollide to true
            count.triggeredCheckpoints++;
        }
    }
}
