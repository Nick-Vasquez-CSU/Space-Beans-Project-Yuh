using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float speed;
	private float regularSpeed;
	private Rigidbody2D rb2d;
    public Animator animator;
    SpriteRenderer sr;

    void Start()
    {
		regularSpeed = 17;
		speed = regularSpeed;
		rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

	void Movement()
	{	
		if (speed > 34) //Prevents speed from exponentially increasing
		{
			speed = 34;
		}

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(speed, 0);
            animator.SetBool("isMoving", true);
            sr.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-speed, 0);
            animator.SetBool("isMoving", true);
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0, speed);
            animator.SetBool("isMoving", true);
            animator.SetBool("isMovingDown", false);
            animator.SetBool("isMovingUp", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0, -speed);
            animator.SetBool("isMoving", true);
            animator.SetBool("isMovingUp", false);
            animator.SetBool("isMovingDown", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
	}
	
    void FixedUpdate()
    {
		Movement();
	}
}
