using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemTracker : MonoBehaviour
{
	//public static ItemTracker Instance;

	public int Beans = 0, Health;
	private int Sammo = 0, Mammo = 0, Snammo = 0;
	public Text BeansText, SammoText, MammoText, SnammoText;
	public Slider HealthSlide;

	private void Awake()
	{
		//if(Instance == null)
		//{
			//Instance = this;
			//DontDestroyOnLoad(gameObject);
		//}
		//else
		//{
			//Destroy(gameObject);
		//}
	}

	void Start()
    {
		GlobalData.Instance.Health = 100;
		HealthSlide.value = GlobalData.Instance.Health;
	}

	void OnTriggerEnter2D(Collider2D other) //Gains stats from colliding with objects 
	{
		if (other.gameObject.CompareTag ("Tier 1 BeanCan"))
		{
			GlobalData.Instance.Beans += 1;
			other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag ("Tier 2 BeanCan"))
		{
			GlobalData.Instance.Beans += 5;
			other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag ("Tier 1 Health Pack"))
		{
			HealthSlide.value += 10;
			other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag ("Tier 2 Health Pack"))
		{
			HealthSlide.value += 100;
			other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag ("Tier S Ammo"))
		{
			GlobalData.Instance.Sammo += 3;
			other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag("Bullet_type2"))
		{
			HealthSlide.value -= 2;
			Destroy(other.gameObject);
		}
		if (other.gameObject.CompareTag("Door"))
		{
			SceneManager.LoadScene("Fungus Flavor Text");
		}
	}

	void DisplayStats()
	{
		BeansText.text = "Beans: " + GlobalData.Instance.Beans.ToString();
		SammoText.text = "Shotgun Ammo: " + GlobalData.Instance.Sammo.ToString();
		MammoText.text = "Machine Gun Ammo: " + GlobalData.Instance.Mammo.ToString();
		SnammoText.text = "Sniper Ammo: " + GlobalData.Instance.Snammo.ToString();
	}

	void HealthTracking()
	{
		if (HealthSlide.value == 0)
		{

			SceneManager.LoadScene("Main Menu");
		}

		if (HealthSlide.value > 100)
		{
			HealthSlide.value = 100;
		}
	}
	void Update()
    {
		DisplayStats();
		HealthTracking();
    }
}
