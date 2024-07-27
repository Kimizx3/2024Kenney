using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using static UnityEngine.EventSystems.BaseEventData;

public class WindowsControl : MonoBehaviour, IPointerClickHandler
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
    
    public virtual void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 2) {
            OpenGameWindow();
        }
    }
    
}
