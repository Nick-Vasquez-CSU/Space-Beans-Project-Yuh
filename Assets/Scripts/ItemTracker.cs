using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour
{
	private int Beans, Health;
	public Text BeansText;
	public Slider HealthSlide;

    void Start()
    {
		Beans = 0;
		Health = 100;
    }

	void OnTriggerEnter2D(Collider2D other) //Gains stats from 
	{
		if (other.gameObject.CompareTag ("Tier 1 BeanCan"))
		{
			Beans += 1;
			other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag ("Tier 2 BeanCan"))
		{
			Beans += 5;
			other.gameObject.SetActive(false);
		}

		if (other.gameObject.CompareTag ("Tier 1 Health Pack"))
		{
			Health += 10;
			other.gameObject.SetActive(false);
		}
	}

	void DisplayStats()
	{
		BeansText.text = "Beans: " + Beans.ToString();

	}
	void Update()
    {
		DisplayStats();
    }
}
