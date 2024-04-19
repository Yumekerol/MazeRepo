using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float elapsedTime;
    public static float pausedTime;
    public static float highscore;
    bool isPaused = false; // Adicionando a declara��o de isPaused
    
    void Update()
    {
        if (!isPaused)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void PauseTimer()
    {
        isPaused = true;
        pausedTime = elapsedTime;
        elapsedTime = 0f;
    }

}
