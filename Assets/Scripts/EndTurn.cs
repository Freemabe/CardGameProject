using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
	public TurnManager turnManager;
	
	public DrawCards DrawCards;

	public GameObject leftHandWeapon;
	public GameObject rightHandWeapon;
	public GameObject leftShoulderWeapon;
	public GameObject rightShoulderWeapon;

	private List<GameObject> weaponList;

	public void Start()
	{
		weaponList = new List<GameObject>();
	}


	public void OnCLick()
	{
		DrawCards.DrawCard();
		if (weaponList.Count == 0);
		{
			weaponList.Add(leftHandWeapon);
			weaponList.Add(rightHandWeapon);
			weaponList.Add(rightShoulderWeapon);
			weaponList.Add(leftShoulderWeapon);
		}

		foreach (GameObject weapon in weaponList)
		{
			weapon.GetComponent<AddWeaponToCombatPool>().hasFiredThisTurn = false;
		}
	}
}
