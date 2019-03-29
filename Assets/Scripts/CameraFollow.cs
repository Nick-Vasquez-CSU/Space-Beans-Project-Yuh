using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float speed;

	public Rigidbody2D rb2d;

    void Start()
    {  
    }

    void FixedUpdate()
    {
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb2d.AddForce(new Vector2(speed, 0));
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb2d.AddForce(new Vector2(-speed, 0));
		}
		if (Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.LeftArrow))
		{
			rb2d.AddForce(new Vector2(0, 0));
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb2d.AddForce(new Vector2(0, speed));
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			rb2d.AddForce(new Vector2(0, -speed));
		}
		if (Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.LeftArrow))
		{
			rb2d.AddForce(new Vector2(0, 0));
		}
	}
}
