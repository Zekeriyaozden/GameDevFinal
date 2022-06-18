using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject gm;
    public float speed;
    private float k;
    private bool isGoingFinish;
    public Vector3 start;
    public Vector3 finish;
    void Start()
    {
        gm = GameObject.Find("GameManager");
        isGoingFinish = true;
        k = 0;
        start = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoingFinish)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            k += speed * Time.deltaTime;
            if (k >= 1)
            {
                isGoingFinish = false;
            }
        }
        else
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180f, 0);
            k -= speed * Time.deltaTime;
            if (k <= 0)
            {
                isGoingFinish = true;
            }
        }
        
        
        gameObject.transform.position = Vector3.Lerp(start, finish, k);


    }

    private IEnumerator dead()
    {
        yield return new WaitForSeconds(4f);
        gm.GetComponent<GameManeger>().deadAgain();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Entered");
            other.gameObject.GetComponent<PlayerControllers>().isAlive = false;
            StartCoroutine(dead());
        }
    }
}
