using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddWeaponToCombatPool : MonoBehaviour
{
	public CombatList combatList;
	public  Texture2D cursorArrow;
	public bool hasFiredThisTurn = false;

	public void OnClick()
	{	
		Debug.Log(hasFiredThisTurn);
		if (!hasFiredThisTurn)
		{
			if (combatList.weaponPool.Count == 0)
			{
				combatList.weaponPool.Add(transform.gameObject);
				combatList.maxSize = this.GetComponent<WeaponStats>().currentFireRate;
			}
			else if (combatList.weaponPool.Count == 1)//ADD A CONFIRMATION BEFORE SWITCH
			{
				combatList.weaponPool.Clear();
				combatList.bodyPool.Clear();
				combatList.weaponPool.Add(transform.gameObject);
				combatList.maxSize = this.GetComponent<WeaponStats>().fireRate.GetValue();
			}
			
			Cursor.SetCursor(cursorArrow,new Vector2(cursorArrow.width/2, cursorArrow.height/2), CursorMode.ForceSoftware);	
		}
		else
		{
			//some notification that this gun has already fired this turn
			Debug.Log(this + "has already fired this turn");
		}
	}
}
