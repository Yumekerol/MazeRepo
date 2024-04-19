using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSfx : MonoBehaviour
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
        if (other.gameObject.tag == "Player")
        {
            print("my moscles are gettin bigger");
            source.Play();

        }        
    }
}
