using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Part/Weapon")]
public class Weapons : Parts{

	public PartSlot partSlot;
	public WeaponType partType;
	public int ammoMax;
	public int damage;


}
    
public enum WeaponType{Ranged, Melee, Defensive}
