using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private readonly int IDLE = 0;
    private readonly int RUNNING = 1;
    private readonly int JUMPING = 2;

    public float speedX;
    public float jumpSpeedY;

    private bool facingRight, jumping, isGrounded;
    private float speed;
    private Rigidbody2D rb;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        facingRight = true;
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer(speed);
        FlipCharacter();
    }

    void MovePlayer(float playerSpeed)
    {
        // if player is jumping or falling
        if (rb.velocity.y != 0)
        {
            jumping = true;
            anim.SetInteger("State", JUMPING);
        }
        else
        {
            jumping = false;
        }

        // if player is running
        if (!jumping && playerSpeed != 0)
        {
            anim.SetInteger("State", RUNNING);
        }

        // if player is standing still
        if (!jumping && playerSpeed == 0)
        {
            anim.SetInteger("State", IDLE);
        }

        // apply velocity to the player to make it move
        rb.velocity = new Vector3(playerSpeed, rb.velocity.y, 0);
    }

    public void MoveLeft()
    {
        speed = -speedX;
    }

    public void MoveRight()
    {
        speed = speedX;
    }

    public void Jump()
    {
        if (!jumping)
        {
            jumping = true;
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
        }
    }

    public void StopMoving()
    {
        speed = 0;
    }

    // flips the character to make it face left or right
    void FlipCharacter()
    {
        if (speed > 0 && !facingRight || speed < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        }
    }

    public void SetIdle()
    {
        anim.SetInteger("State", IDLE);
    }
}

