using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPanel : MonoBehaviour {

    public GameObject currentPanel;
    public GameObject newPanel;

    public void PanelSwitch()
    {
        currentPanel.SetActive(false);
        newPanel.SetActive(true);
    }


}
