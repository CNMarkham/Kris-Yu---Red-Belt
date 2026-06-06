using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;
    public int modifyX = 0;
    public int modifyZ = 0;

    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            Instantiate(itemBox, new Vector3(transform.position.x + i * modifyX, transform.position.y, transform.position.z + i * modifyZ), transform.rotation);
        }
    }
    void Update()
    {
        
    }
}
