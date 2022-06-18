using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject player;
    public GameObject Camera;
    public int level;
    private int key;
    public Vector3 lvl1;
    public Vector3 lvl2;
    public Vector3 lvl3;
    public Vector3 lvl4;
    public Vector3 lvl1Camera;
    public Vector3 lvl2Camera;
    public Vector3 lvl3Camera;
    public Vector3 lvl4Camera;
    void Start()
    {
        key = 0;
        level = 1;
        player.transform.position = lvl1;
        Camera.transform.position = lvl1Camera;
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 2)
        {
            Level2();
        }else if (level == 3)
        {
            Level3();;
        }else if (level == 4)
        {
            Level4();
        }
    }

    public void Level2()
    {
        if (key == 0)
        {
            player.transform.position = lvl2;
            Camera.transform.position = lvl2Camera;
        }

        key = 1;
    }
    public void Level3()
    {
        if (key == 1)
        {
            player.transform.position = lvl3;
            Camera.transform.position = lvl3Camera;
        }

        key = 2;
    }
    public void Level4()
    {
        if (key == 2)
        {
            player.transform.position = lvl4;
            Camera.transform.position = lvl4Camera;
        }

        key = 0;

    }
    
    
}
