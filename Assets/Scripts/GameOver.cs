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
        Time.timeScale = 0; 
        Pause();

    }

    public void Pause()
    {
        PausePanel.SetActive(true);

    }
    public void MenuGame()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;

    }

    public void MainGame()
    {
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;

    }
}
