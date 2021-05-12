using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPanelEngine : MonoBehaviour
{	public Engines part;
  	public GameObject displayPanel;
  	public GameObject weightNumber;
  	public GameObject field1Number;
  	public GameObject field2Number;

  	public void UpdateText()
  	{
	    weightNumber.GetComponent<TMPro.TextMeshProUGUI>().text = part.weight.ToString(); 
	    field1Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.outputPower.ToString();
	    field2Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.energyRequired.ToString();
  	}
}