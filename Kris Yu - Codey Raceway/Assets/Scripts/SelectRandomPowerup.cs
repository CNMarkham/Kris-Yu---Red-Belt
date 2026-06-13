using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    float spawnDistance = 6f;

    void Update()
    {
        attack();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }

    private void attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (chosenPowerup != null)
            {
                Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;
                Instantiate(chosenPowerup, spawnPosition, transform.rotation);
                chosenPowerup = null;
            }
        }
    }
}
