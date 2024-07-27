using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInitialization : MonoBehaviour
{

    public GameObject WindowPanel;

    private void Start()
    {
        SceneManager.LoadScene("Platformer", LoadSceneMode.Additive);
    }


    public void OpenGameWindow()
    {
        WindowPanel.SetActive(true);
    }

    public void CloseGameWindow()
    {
        WindowPanel.SetActive(false);
    }
}
