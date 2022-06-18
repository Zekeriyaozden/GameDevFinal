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
    public bool isAlive;
    void Start()
    {
        isAlive = true;
        boxCollider2d = gameObject.GetComponent<BoxCollider2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    gameObject.GetComponent<Animator>().SetBool("idle",false);
                    gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
                    gameObject.transform.eulerAngles = new Vector3(0,0,0);
                    gameObject.GetComponent<Animator>().SetBool("isSneaking",true);
                }
                else
                {
                    gameObject.GetComponent<Animator>().SetBool("idle",false);
                    gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
                    gameObject.transform.eulerAngles = new Vector3(0,0,0);
                    gameObject.GetComponent<Animator>().SetBool("isRunning",true);
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.GetComponent<Animator>().SetBool("idle",false);
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
                    gameObject.transform.eulerAngles = new Vector3(0,180f,0);
                    gameObject.GetComponent<Animator>().SetBool("isSneaking",true);  
                }
                else
                {
                    gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
                    gameObject.transform.eulerAngles = new Vector3(0,180f,0);
                    gameObject.GetComponent<Animator>().SetBool("isRunning",true);
                }
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.GetComponent<Animator>().SetBool("idle",false);
                gameObject.GetComponent<Animator>().SetBool("isSneaking",true);
            }
            else
            {
                gameObject.GetComponent<Animator>().SetBool("idle",true);
                gameObject.GetComponent<Animator>().SetBool("isSneaking",false);  
                gameObject.GetComponent<Animator>().SetBool("isRunning",false);
                
            }

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                gameObject.GetComponent<Animator>().SetBool("idle",false);
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpVelocity;
                gameObject.GetComponent<Animator>().SetBool("isJumping",true);
            }
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("isJumping",false);
            gameObject.GetComponent<Animator>().SetBool("idle",false);
            gameObject.GetComponent<Animator>().SetBool("isSneaking",false);  
            gameObject.GetComponent<Animator>().SetBool("isRunning",false);
            gameObject.GetComponent<Animator>().SetBool("isDead",true);
            
        }
    }
    
    //public void 
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            gameObject.GetComponent<Animator>().SetBool("isJumping",false);
            gameObject.GetComponent<Animator>().SetBool("idle",true);
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
