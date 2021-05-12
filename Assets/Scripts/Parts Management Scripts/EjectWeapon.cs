using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectWeapon : MonoBehaviour
{
	public GameObject parent;
	public GameObject sibling;
	int childNumber;

	public void OnClick(){
		childNumber = parent.transform.childCount;
		for (int i =0 ; i <childNumber; i++)
		{
			if (!parent.transform.GetChild(i).name.Contains("Eject Weapon"))
			{
				parent.transform.GetChild(i).gameObject.SetActive(false);
				//parent.transform.GetChild(i).position = partpool.transform.position;
			}
		}
		sibling.GetComponent<PartFetch>().isEmpty = true;
	}
}
