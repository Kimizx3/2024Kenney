using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSwitch : MonoBehaviour
{
    public GameObject[] panles;
    public Button[] buttons;

    private void Start()
    {
        // Ensure only the first panel is active at the start
        for (int i = 0; i < panles.Length; i++)
        {
            panles[i].SetActive(i == 0);
        }

        // Add click listeners to each button
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Capture index for the closure
            buttons[i].onClick.AddListener(() => SwitchPanel(index));
        }
    }

    void SwitchPanel(int index)
    {
        // Deactive all panels
        for (int i = 0; i < panles.Length; i++)
        {
            panles[i].SetActive(false);
        }
        
        // Active the selected panel
        panles[index].SetActive(true);
    }
}
