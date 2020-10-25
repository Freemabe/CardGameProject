using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectWeapon : MonoBehaviour
{
	public GameObject parent;
	public GameObject partpool;
	int childNumber;

	public void OnClick(){
		childNumber = parent.transform.childCount;
		for (int i =0 ; i <childNumber; i++)
		{
			if (parent.transform.GetChild(i).name.Contains("WeaponPrefab"))
			{
				parent.transform.GetChild(i).SetParent(partpool.transform, false);
				//parent.transform.GetChild(i).position = partpool.transform.position;
			}
		}
		parent.GetComponent<PartFetch>().isEmpty = true;
	}
}
