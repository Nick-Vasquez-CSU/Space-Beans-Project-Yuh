using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GAMEPLAY1");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits_Scene");
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
