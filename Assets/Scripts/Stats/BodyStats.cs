using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyStats : MonoBehaviour
{
	public GameObject destroyedPartsPool;

	public Parts basePart;

	public bool isAlive = true;

	public Stat structure;
	public Stat armor;
	public Stat armorToughness;

	public int currentStructure {get; protected set;}
	public int currentArmor {get; protected set;}

	//set up values that will move
	public virtual void Start(){
		Body basePart1 = (Body) basePart;
		armor.baseValue = basePart1.armorPoints;
		armorToughness.baseValue = basePart1.armorToughness;
		structure.baseValue = basePart1.structurePoints;
		currentArmor = armor.GetValue();
		currentStructure = structure.GetValue();
	}



	public void TakeDamage (int damage)
	{
		if (currentArmor > 0)
		{
			damage -= armorToughness.GetValue();
			damage = Mathf.Clamp(damage, 0, int.MaxValue);
			//beat up that armor
			if (currentArmor >= damage){
			currentArmor -= damage;
			}
			// overflow dmg
			if (currentArmor < damage){
			damage -= currentArmor;
			currentArmor = 0;
			currentStructure -=damage;

			}

		}
		//Jet fuel CAN melt these steel beams
		else
		{
			damage = Mathf.Clamp(damage, 0, int.MaxValue);

			currentStructure -= damage;
		}
		//after everything is done check if the part is destroyed.
		if (currentStructure<=0)
		{
			Destroy();
		}
	}

	public void Destroy()
	{
		this.GetComponent<IsTarget>().isTarget = false;
		this.GetComponent<PartDisplay>().artworkImage.sprite = basePart.destroyedIcon;
		isAlive = false;

	}
}
