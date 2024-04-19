using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiamondSfx : MonoBehaviour
{
    public AudioSource source;
    Collider sound_trigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        sound_trigger = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Diamond")
        {
            print("my moscles are gettin bigger");
            source.Play();

        }
    }
}
