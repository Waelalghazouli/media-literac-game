using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    //Declaring some Variables
    Animator animator;
    Rigidbody2D rBody;
    float speed;

    // Animation
    bool facingRight, jumping;      // For turning the face to left and right when moving
    private readonly int IDLE = 0;
    private readonly int RUNNING = 1;
    private readonly int JUMPING = 2;

    // Defining the PUBLIC varibles which you can change simple way using unity itself
    public float speedX;            // Player vertical speed
    public float speedY;            // Jumping speed



    // Start is called before the first frame update
    void Start()
    {
        // Storing the references of the animator component which is attached to the player
        animator = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();

        facingRight = true;         // The player will start by lloking to the right side

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
        if (rBody.velocity.y != 0)
        {
            jumping = true;
            animator.SetInteger("State", JUMPING);
        }
        else
        {
            jumping = false;
        }

        // if player is running
        if (!jumping && playerSpeed > 0 || !jumping && playerSpeed < 0)
        {
            animator.SetInteger("State", RUNNING);
        }

        // if player is standing still
        if (!jumping && playerSpeed == 0)
        {
            animator.SetInteger("State", IDLE);
        }

        // apply velocity to the player to make it move
        rBody.velocity = new Vector3(playerSpeed, rBody.velocity.y, 0);
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
            rBody.AddForce(new Vector2(rBody.velocity.x, speedY));
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
        animator.SetInteger("State", IDLE);
    }
}