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

    }

    private IEnumerator setAnim()
    {
        yield return new WaitForSeconds(2f);
        player.GetComponent<Animator>().SetBool("again",false);
    }

    public void deadAgain()
    {
        player.GetComponent<Animator>().SetBool("isDead",false);
        player.GetComponent<Animator>().SetBool("again",true);
        player.GetComponent<PlayerControllers>().isAlive = true;
        StartCoroutine(setAnim());
        if (level == 1)
        {
            Level1();
        }
        if (level == 2)
        {
            Level2();
        }
        if (level == 3)
        {
            Level3();
        }
        if (level == 4)
        {
            Level4();
        }
    }
    public void Level1()
    {
        player.transform.position = lvl1;
        Camera.transform.position = lvl1Camera;
    }
    public void Level2()
    {

            player.transform.position = lvl2;
            Camera.transform.position = lvl2Camera;
        

    }
    public void Level3()
    {

            player.transform.position = lvl3;
            Camera.transform.position = lvl3Camera;

    }
    public void Level4()
    {
        player.transform.position = lvl4;
        Camera.transform.position = lvl4Camera;
    }
    
    
}
