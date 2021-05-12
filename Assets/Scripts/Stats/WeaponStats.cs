using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour
{
	public Parts weaponPart;
	
	public Stat ammoMax;
	public Stat damage;
	public Stat fireRate;
	
	public string weaponType;

	public int currentAmmo;
	public int currentDamage;
	public int currentFireRate;

	public virtual void Start()
	{
		Weapons weaponPart1 = (Weapons) weaponPart;
		ammoMax.baseValue = weaponPart1.ammoMax;
		currentAmmo = ammoMax.GetValue();

		damage.baseValue = weaponPart1.damage;
		currentDamage = damage.GetValue();

		fireRate.baseValue = weaponPart1.fireRate;
		currentFireRate = fireRate.GetValue();

		weaponType = weaponPart1.partType.ToString();

	}

	public virtual int Attack()
	{
		
		if (currentAmmo > 0)
		{
			return currentDamage;
		}
		else
		{
			Debug.Log(this.name + " is out of ammo");
			return 0;
		}

	}

	public virtual void DrainAmmo()
	{
		currentAmmo --;
		currentAmmo = Mathf.Clamp(currentAmmo, 0, int.MaxValue);
	}

}