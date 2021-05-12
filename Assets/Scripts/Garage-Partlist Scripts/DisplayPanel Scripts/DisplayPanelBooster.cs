using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPanelBooster : MonoBehaviour
{
  public Boosters part;
  public GameObject displayPanel;
  public GameObject weightNumber;
  public GameObject field1Number;
  public GameObject field2Number;

  public void UpdateText()
  {
    weightNumber.GetComponent<TMPro.TextMeshProUGUI>().text = part.weight.ToString(); 
    field1Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.thrust.ToString();
    field2Number.GetComponent<TMPro.TextMeshProUGUI>().text = part.energyRequired.ToString();
  }
}
