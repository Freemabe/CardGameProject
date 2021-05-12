using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPanelLegs : MonoBehaviour
{
    public LeftLegs part;
  	public GameObject displayPanel;
  	public GameObject weightNumber;
  	public GameObject field1Number;
  	public GameObject field2Number;
  	public GameObject field3Number;
  	public GameObject field4Number;
  	public GameObject field5Number;
    public BoolHolder leftRightBool;


  	public void UpdateText()
    {
        if (leftRightBool.boolValue)
        {
          weightNumber.GetComponent<TMPro.TextMeshProUGUI>().text = part.weight.ToString(); 
          field1Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.structurePoints.ToString();
          field2Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.armorPoints.ToString();
          field3Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.armorToughness.ToString();
          field4Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.weightCapacity.ToString(); 
          field5Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.moveSpeed.ToString(); 
        }
        else
        {
        weightNumber.GetComponent<TMPro.TextMeshProUGUI>().text = part.pairPart.weight.ToString(); 
        field1Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.pairPart.structurePoints.ToString();
        field2Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.pairPart.armorPoints.ToString();
        field3Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.pairPart.armorToughness.ToString();
        field4Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.pairPart.weightCapacity.ToString();
        field5Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.pairPart.moveSpeed.ToString(); 
        }
    	
  	}
}
