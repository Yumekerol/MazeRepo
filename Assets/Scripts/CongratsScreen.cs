using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CongratsScreen : MonoBehaviour
{
    public GameObject PausePanel;
    public TextMeshProUGUI timeText;
    public Time timeScore;

    public void Setup()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0; // Assuming this is where you want to pause the game
        Pause();
        DisplayTime();
    }

    public void MenuGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void DisplayTime()
    {
        float totalElapsedTime = Timer.pausedTime + Time.time - Time.timeScale * Time.realtimeSinceStartup;
        int minutes = Mathf.FloorToInt(totalElapsedTime / 60);
        int seconds = Mathf.FloorToInt(totalElapsedTime % 60);
        timeText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }


}
