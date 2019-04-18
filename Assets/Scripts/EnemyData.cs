using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
	private int Health, Damage;
	public int Enemydiff, Enemytype;
	public GameObject self;
    void Start()
    {
		BaseStats();
    }

    void BaseStats()
	{	if (Enemytype == 2)
		{
			if (Enemydiff == 1)
			{
				Health = 10;
				Damage = 1;
			}
			else if (Enemydiff == 2)
			{
				Health = 20;
				Damage = 5;
			}
			else if (Enemydiff == 3)
			{
				Health = 30;
				Damage = 10;
			}
		} 
		
		else if (Enemytype == 1)
		{
			if (Enemydiff == 1)
			{
				Health = 5;
				Damage = 1;
			}
			else if (Enemydiff == 2)
			{
				Health = 10;
				Damage = 5;
			}
			else if (Enemydiff == 3)
			{
				Health = 20;
				Damage = 10;
			}
		}
		else
		{
			Debug.Log("Invalid Difficulty lulw");
		}

		//if(Enemytype == 1)
	//	{
	//
		//}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Bullet_type1"))
		{
			Health -= 3;
			Destroy(other.gameObject);
		}

	}

	void UpdatedStats()
	{
		if (Health <= 0)
		{
			self.SetActive(false);
		}
	}

	void EnemyAI()
	{

	}
    void Update()
    {
		UpdatedStats();
		EnemyAI();
    }
}
