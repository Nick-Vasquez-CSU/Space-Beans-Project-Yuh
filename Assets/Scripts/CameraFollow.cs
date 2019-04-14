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

		if (Input.GetKey(KeyCode.D))
		{
			rb2d.velocity = new Vector2(speed, 0);
		}
		if (Input.GetKey(KeyCode.A))
		{
			rb2d.velocity = new Vector2(-speed, 0);
		}
		if (Input.GetKey(KeyCode.W))
		{
			rb2d.velocity = new Vector2(0, speed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			rb2d.velocity = new Vector2(0, -speed);
		}
	}
	
    void FixedUpdate()
    {
		Movement();
	}
}
