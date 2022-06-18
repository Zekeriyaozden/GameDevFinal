using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    public bool isGrounded;
    public float speed;
    public float JumpVelocity;
    private BoxCollider2D boxCollider2d;
    void Start()
    {
        boxCollider2d = gameObject.GetComponent<BoxCollider2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
        }
        
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpVelocity;
        }
        
        
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            isGrounded = false;
        }
        
    }
}
