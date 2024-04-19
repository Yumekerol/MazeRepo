using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameOver gameover;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameOver();
            print("Gotcha!");

        }
    }

    private void GameOver()
    {
        gameover.Setup();
    }
}
