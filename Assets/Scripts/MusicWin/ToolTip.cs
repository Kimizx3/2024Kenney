using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public GameObject toolTip;

    private void Start()
    {
        toolTip.SetActive(false);
    }

    public void OnMouseOver()
    {
        toolTip.SetActive(true);
    }

    public void OnMouseExit()
    {
        toolTip.SetActive(false);
    }
}
