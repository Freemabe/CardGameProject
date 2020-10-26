using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyStats : MonoBehaviour
{
	public Body basePart;
	public Stat structure;
	public Stat armor;
	public Stat armorToughness;

	public int currentStructure {get; protected set;}
	public int currentArmor {get; protected set;}

	public virtual void Start(){
		armor.baseValue = basePart.armorPoints;
		armorToughness.baseValue = basePart.armorToughness;
		structure.baseValue = basePart.structurePoints;
		currentArmor = armor.GetValue();
		currentStructure = structure.GetValue();
	}



	public void TakeDamage (int damage){
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
			damage -= armorToughness.GetValue();
			damage = Mathf.Clamp(damage, 0, int.MaxValue);

			currentStructure -= damage;
		}
}
}