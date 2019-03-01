using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float speed;
	private float regularSpeed;
	private Rigidbody2D rb2d;

    void Start()
    {
		regularSpeed = 17;
		speed = regularSpeed;
		rb2d = GetComponent<Rigidbody2D>();   
    }

	void Movement()
	{	
		if (speed > 34) //Prevents speed from exponentially increasing
		{
			speed = 34;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			speed = regularSpeed;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb2d.velocity = new Vector2(speed, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb2d.velocity = new Vector2(-speed, 0);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb2d.velocity = new Vector2(0, speed);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			rb2d.velocity = new Vector2(0, -speed);
		}
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			speed = speed * 2;
		}
	}

    void FixedUpdate()
    {
		Movement();
	}
}
