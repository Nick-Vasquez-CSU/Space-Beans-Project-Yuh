using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour
{
	private int Beans, Health, Sammo, Mammo, Rammo;
	public Text BeansText, SammoText, MammoText, RammoText;
	public Slider HealthSlide;

    void Start()
    {
		Sammo = 0;
		Mammo = 0;
		Beans = 0;
		Health = 100;
    }

	void OnTriggerEnter2D(Collider2D other) //Gains stats from colliding with objects 
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
		if (other.gameObject.CompareTag ("Tier S Ammo"))
		{
			Sammo += 3;
			other.gameObject.SetActive(false);
		}
	}

	void DisplayStats()
	{
		BeansText.text = "Beans: " + Beans.ToString();
		SammoText.text = "Shotgun Ammo: " + Sammo.ToString();
		MammoText.text = "Machine Gun Ammo: " + Mammo.ToString();
		RammoText.text = "Rocket Ammo: " + Rammo.ToString();
	}

	void HealthTracking()
	{
		HealthSlide.value = Health;
		if (HealthSlide.value == 0)
		{
			// Call death screen
		}

		if (Health >= 100)
		{
			Health = 100;
		}
	}
	void FixedUpdate()
    {
		DisplayStats();
		HealthTracking();
    }
}
