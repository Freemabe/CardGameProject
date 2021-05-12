using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPanelGenerator : MonoBehaviour
{
    public Generators part;
  	public GameObject displayPanel;
  	public GameObject weightNumber;
  	public GameObject field1Number;


  	public void UpdateText()
  	{
    	weightNumber.GetComponent<TMPro.TextMeshProUGUI>().text = part.weight.ToString(); 
    	field1Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.energyOutput.ToString();
    	
  	}
}
