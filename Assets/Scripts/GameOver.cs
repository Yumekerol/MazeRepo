using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void MenuGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void MainGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
