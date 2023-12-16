using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUIManager : MonoBehaviour
{

    public GameObject uiPanel;

   public void HowTo()
    {
        uiPanel.SetActive(true);
    }

    public void hideUI()
    {
        uiPanel.SetActive(false);
    }
}
