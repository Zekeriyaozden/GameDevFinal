using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    public float speed;
    private float k;
    private bool isGoingFinish;
    public Vector3 start;
    public Vector3 finish;
    void Start()
    {
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
}
