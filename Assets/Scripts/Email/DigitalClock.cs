using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DigitalClock : MonoBehaviour
{
    public TextMeshProUGUI clockText;

    private void Update()
    {
        DateTime now = DateTime.Now;
        clockText.text = now.ToString("yyyy-MM-dd HH:mm:ss tt");
    }
}
