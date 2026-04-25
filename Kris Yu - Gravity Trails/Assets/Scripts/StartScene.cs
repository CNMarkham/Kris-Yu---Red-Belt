using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("Level1");
    }

    void Update()
    {
        
    }
}
