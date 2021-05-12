using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPanelWeapon : MonoBehaviour
{
	public Weapons part;
  	public GameObject displayPanel;
  	public GameObject weightNumber;
  	public GameObject field1Number;
  	public GameObject field2Number;
  	public GameObject field3Number;
  	public GameObject field4Number;

  	public void UpdateText()
	{
    	weightNumber.GetComponent<TMPro.TextMeshProUGUI>().text = part.weight.ToString(); 
    	field1Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.ammoMax.ToString();
    	field2Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.damage.ToString();
    	field3Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.fireRate.ToString();
    	field4Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.partType.ToString();
  	}
}
