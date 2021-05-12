using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion", menuName = "Card/Minion")]
public class Minion : Card
{
	public int damage;
	public int fireRate;
	public int ammoMax;

	public int armor;
	public int structure;
	public int armorToughness;
}
