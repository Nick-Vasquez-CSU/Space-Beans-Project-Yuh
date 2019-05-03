using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyWaves : MonoBehaviour
{
	private int WaveNumber, EnemiesRem, EnemiesTotal, xSpawn, ySpawn;
	public GameObject Enemy1_1, Enemy1_2, Enemy1_3, Enemy2_1, Enemy2_2, Enemy2_3,  Door;
	public Text enemyText;

   // void Awake()
   // {
	//	WaveNumber = 0;
	//	EnemiesRem = 50;
	//	StartCoroutine("Everything");
	//	StartCoroutine("Spawning");
	//	Door.SetActive(false);
   // }

	void Start()
	{
		WaveNumber = 0;
		EnemiesRem = 50;
		StartCoroutine("Spawning");
		Door.transform.position = new Vector2(-30, 7);
	}

	void Update()
	{
		enemyText.text = "Remaining Enemies: " + EnemiesRem.ToString();
		StartCoroutine("Everything");
	}
	IEnumerator Everything()
	{
		if (EnemiesRem <= 0)
		{
			Door.transform.position = new Vector2(286f, 45f);
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
			if (WaveNumber <= 3)
			{
				Object.Instantiate(Enemy1_1, new Vector2(x: Random.Range(240f, 305f), y: Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy1_1, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_1, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_1, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_1, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
			}
			else if (WaveNumber <= 6)
			{
				Object.Instantiate(Enemy1_2, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy1_2, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy1_2, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_2, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_2, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
			}
			else if (WaveNumber <= 10)
			{
				Object.Instantiate(Enemy1_3, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy1_3, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_3, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_3, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
				Object.Instantiate(Enemy2_3, new Vector2(Random.Range(240f, 305f), Random.Range(15f, 60f)), Quaternion.identity);
			}
			EnemiesRem -= 5;
			yield return new WaitForSeconds(10);
		}
	}

}
