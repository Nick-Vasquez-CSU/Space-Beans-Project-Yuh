using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
	private int Health;
	public int Enemydiff, Enemytype;
	public GameObject self;
    void Start()
    {
		BaseStats();
    }

    void BaseStats()
	{
		if (Enemydiff == 1)
		{
			Health = 10;
		}
		else if (Enemydiff == 2)
		{
			Health = 20;
		}
		else if (Enemydiff == 3)
		{
			Health = 30;
		}
		else
		{
			Debug.Log("Invalid Difficulty lulw");
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Bullet_type1"))
		{
			Health -= 10;
			other.gameObject.SetActive(false);
		}

	}

	void UpdatedStats()
	{
		if (Health <= 0)
		{
			self.SetActive(false);
		}
	}
    void Update()
    {
		UpdatedStats();
    }
}
