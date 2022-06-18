using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    AudioSource audio;
    public GameObject door;
    void Start()
    {
            audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        audio.Play();
        if (other.tag == "Player")
        {
            
            door.GetComponent<DoorController>().isOpen = true;
            gameObject.SetActive(false);
        }
    }
}
