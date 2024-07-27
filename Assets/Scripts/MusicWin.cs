using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicWin : MonoBehaviour
{
    public GameObject WindowPanel;

    public void OpenGameWindow()
    {
        WindowPanel.SetActive(true);
    }

    public void CloseGameWindow()
    {
        WindowPanel.SetActive(false);
    }
}