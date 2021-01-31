using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public GameObject creditsPanel;
    public GameObject levelSelectPanel;

    public void Start()
    {
        if(EyeBehaviour.hasBothEyes == true)
        {
            StartButton();
        }
    }

    public void StartButton()
    {
        levelSelectPanel.SetActive(true);
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void Quit()
    {
        Quit();
    }

    public void Back()
    {
        levelSelectPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
