using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ConfirmDialog;

    public void StartGame()
    {
        SceneManager.LoadScene("DesktopScene");
    }

    public void QuitGame()
    {
        ConfirmDialog.SetActive(true);
    }

    public void confirmQuit()
    {
        Application.Quit();
    }

    public void CancelQuit()
    {
        ConfirmDialog.SetActive(false);
    }
}
