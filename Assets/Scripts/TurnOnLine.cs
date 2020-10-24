using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLine : MonoBehaviour
{

	public void OnClick()
	{
		Debug.Log("Is this shit working");
		this.GetComponent<TargetLine>().enable = true;
		this.GetComponent<TargetLine>().Update();
	}
}
