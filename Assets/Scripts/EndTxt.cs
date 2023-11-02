using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTxt : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
