using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public TMP_Text statusText;

    public void UpdateStatus(string status)
    {
        statusText.text = status;
    }
}
