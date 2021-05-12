using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddBodyToCombatPool : MonoBehaviour
{
	public CombatList combatList;
	public GameObject crosshairs;
	private bool isTarget;
	


	public void OnClick()
	{
		isTarget = this.GetComponent<IsTarget>().isTarget;
		
		if(combatList.weaponPool.Count > 0 && combatList.currentSum < combatList.maxSize && isTarget)
		{	combatList.currentSum = 0;
			if (!combatList.bodyPool.ContainsKey(this.gameObject))
			{
				combatList.bodyPool[this.gameObject] = 1;
				GameObject crossHairImage = Instantiate(crosshairs,Vector3.zero, Quaternion.identity);
				crossHairImage.transform.SetParent(this.transform, false);
			}
			else if(combatList.bodyPool.ContainsKey(this.gameObject))
			{
				combatList.bodyPool[this.gameObject] += 1;
			}
			foreach (KeyValuePair<GameObject,int> kvp in combatList.bodyPool)
			{
				combatList.currentSum +=kvp.Value;
				Debug.Log(combatList.currentSum);
			}
			
		}	
	}
}
