using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalData : MonoBehaviour
{
	public static GlobalData Instance;

	public int Beans = 0, Health;
	public int Sammo = 0, Mammo = 0, Snammo = 0;
	public Text BeansText, SammoText, MammoText, SnammoText;
	public Slider HealthSlide;

	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	
}
