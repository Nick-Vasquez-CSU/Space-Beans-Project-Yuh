using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
	public float velX = 5f, velY = 0f;
	Rigidbody2D rb;

	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
		rb.velocity = new Vector2(velX, velY);
    }
}
