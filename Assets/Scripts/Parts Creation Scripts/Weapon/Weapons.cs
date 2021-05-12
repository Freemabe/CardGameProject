using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Part/Weapon")]
public class Weapons : Parts{

	public WeaponType partType;
	public int ammoMax;
	public int damage;
	public int fireRate;

	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Max Ammo", ammoMax);
		InfoDict.Add("Damage Per Shot", damage);
		InfoDict.Add("Fire Rate", fireRate);


		return InfoDict;
	}

}
    
public enum WeaponType{Ranged, Melee, Defensive}
