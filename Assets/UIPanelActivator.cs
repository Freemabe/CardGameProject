using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelActivator : MonoBehaviour
{
    public GameObject UIPanel;
    public GameObject UIPartner;

    public void Onclick()
    {
    	
    	UIPanel.SetActive(true);
    	UIPartner.SetActive(false);
    }
}
