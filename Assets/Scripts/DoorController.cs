using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen;
    public int nextLevel;
    private GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isOpen)
            {
                Debug.Log("NextLevel");
                gm.GetComponent<GameManeger>().level = nextLevel;
                if (nextLevel == 2)
                {
                    gm.GetComponent<GameManeger>().Level2();
                }
                if (nextLevel == 3)
                {
                    gm.GetComponent<GameManeger>().Level3();
                }
                if (nextLevel == 4)
                {
                    gm.GetComponent<GameManeger>().Level4();
                }
            }
        }
    }
}
