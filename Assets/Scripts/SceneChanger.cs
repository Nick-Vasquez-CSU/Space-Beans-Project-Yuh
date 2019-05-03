using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.I))
		{
			SceneManager.LoadScene("Level 1_temp");
		}
	}

	public void PlayButton()
    {
        SceneManager.LoadScene("Level 1_temp");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits_Scene");
    }

	public void InstructButton()
	{
		SceneManager.LoadScene("Instructions");
	}

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
