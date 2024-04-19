using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject PausePanel;
    public void Setup()
    {
        gameObject.SetActive(true);
       
    }
    public void MenuGame()
    {
        SceneManager.LoadSceneAsync(0);
        
    }

    public void MainGame()
    {
        SceneManager.LoadSceneAsync(1);
        
    }
}
