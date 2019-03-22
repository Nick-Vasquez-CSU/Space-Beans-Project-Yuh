using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyWaves : MonoBehaviour
{
	private int WaveNumber, EnemiesRem, EnemiesTotal;
	public GameObject Enemy1, Door;


    void Start()
    {
		WaveNumber = 1;
		EnemiesRem = 0;
		EnemiesTotal = 1;
		StartCoroutine("Everything");
		StartCoroutine("Spawning");
		Door.SetActive(false);
    }

	void WaveSystem()
	{

		for(int cur = 0; cur < WaveNumber; cur++)
		{
			EnemiesTotal = EnemiesTotal * 2;
		}

		if (EnemiesRem == 0)
		{
			Door.SetActive(true);
		}
	}

	void EnemySpawning()
	{
		if (WaveNumber == 10)
		{
			//Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}
		// Actual spawning
		Spawning();
	}

	
    void Update()
    {
		WaveSystem();
		EnemySpawning();
    }
	IEnumerator Everything()
	{
		if (EnemiesRem == 0)
		{
			yield return new WaitForSeconds(30);
			SceneManager.LoadScene("MerchantScene");
		}
	}
	IEnumerator Spawning()
	{
		for (int cur = 0; cur < 10; cur++)
		{
			WaveNumber += 1;
			Debug.Log(WaveNumber);
			yield return new WaitForSeconds(4);
		}
	}

}
