using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeWin : MonoBehaviour
{
    public GameObject WindowPanel;

    public void Toggle()
    {
        WindowPanel.SetActive(!WindowPanel.activeSelf);
    }
}
