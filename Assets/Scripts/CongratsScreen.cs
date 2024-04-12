using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CongratsScreen : MonoBehaviour
{

    public void Setup()
    {
        gameObject.SetActive(true);
    }
    public void MenuGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
