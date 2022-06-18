using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggController : MonoBehaviour
{
    public GameObject easterEgg;
    void Start()
    {
        easterEgg.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            easterEgg.gameObject.SetActive(true);
        }
    }
}
