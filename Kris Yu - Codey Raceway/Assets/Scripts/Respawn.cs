using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("terrain"))
        {
            Destroy(gameObject);
            ReloadScene();
        }
    }

    private void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }


}
