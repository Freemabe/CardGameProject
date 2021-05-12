using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestTest : MonoBehaviour
{
	[SerializeField]
	private BoolHolder UIDisplayBool;
	
    public void OnPointerClick(PointerEventData eventData)
    {
    	if(eventData.button == PointerEventData.InputButton.Right && UIDisplayBool.boolValue == true)
		{
			ToolTipUI.HideTooltip_Static();
			UIDisplayBool.boolValue = false;
		}
    }
}
