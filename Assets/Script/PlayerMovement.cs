using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jump = 10;
    public Rigidbody2D rb;
    public bool onFloor = false;
    private bool isFacingRight = true;
    public float inputX;
    public Animator anim;

    //public StartGame startGame;
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && onFloor == true) {
            anim.SetBool("Jump", true);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
            onFloor = false;
        }

        if (inputX >= 0.1f || inputX <= -0.1f) {
            anim.SetBool("Move", true);
        } else {
            anim.SetBool("Move", false);
        }
        
        rb.linearVelocity = new Vector2(inputX * speed, rb.linearVelocity.y);
        Flip();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground") {
            onFloor = true;
            anim.SetBool("Jump", false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground") {
            onFloor = false;
        }
    }


    private void Flip()
    {
        if (isFacingRight && inputX < 0f || !isFacingRight && inputX > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}