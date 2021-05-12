using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ToolTipShowup : MonoBehaviour, IPointerClickHandler
{	
	public BoolHolder UIDisplayBool;
	

	public void OnPointerClick(PointerEventData eventData)
	{	
		
		string Displaystring ="";
		Dictionary<string,int> DisplayInfoDict = transform.parent.GetComponent<PartDisplay>().part.PublicDisplayInfo();
		foreach (KeyValuePair<string,int> kvp in DisplayInfoDict)
		{
			Displaystring += $"{kvp.Key}: {kvp.Value}\n";
		}
		if (transform.parent.GetComponent<BodyStats>() != null)
		{
			Displaystring +=$"Current Structure: {transform.parent.GetComponent<BodyStats>().currentStructure}\n";
			Displaystring +=$"Current Armor:{transform.parent.GetComponent<BodyStats>().currentArmor}\n";
		}
		if (transform.parent.GetComponent<WeaponStats>() != null)
		{
			Displaystring +=$"Current Damage: {transform.parent.GetComponent<WeaponStats>().currentDamage}\n";
			Displaystring +=$"Current Fire Rate:{transform.parent.GetComponent<WeaponStats>().currentFireRate}\n";
			Displaystring +=$"Current Ammo:{transform.parent.GetComponent<WeaponStats>().currentAmmo}\n";
		}
		if(eventData.button == PointerEventData.InputButton.Right && UIDisplayBool.boolValue == true)
		{
			ToolTipUI.HideTooltip_Static();
			UIDisplayBool.boolValue = false;
		}
		else if(eventData.button == PointerEventData.InputButton.Right && UIDisplayBool.boolValue == false)
		{
			ToolTipUI.ShowTooltip_Static(transform.parent.name + "\n" + Displaystring);
			UIDisplayBool.boolValue = true;
		}
	}

	public void OnMouseExit()
    {
    	
    	ToolTipUI.HideTooltip_Static();
    	UIDisplayBool.boolValue = false;    
    }
}
