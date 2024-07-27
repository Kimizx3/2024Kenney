using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EmailSystem : MonoBehaviour
{
    public GameObject EmailContent;

    public void OpenEmail()
    {
        EmailContent.SetActive(true);
    }

    public void CloseEmail()
    {
        EmailContent.SetActive(false);
    }
}
