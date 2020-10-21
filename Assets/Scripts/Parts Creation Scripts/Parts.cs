using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Parts : ScriptableObject {

	new public string name = "New Items";
	public Sprite Icon;
	public int weight;
}


public enum PartSlot { Head, LeftArm, RightArm, LeftLeg, RightLeg, 
	Torso, Engine, Generator, Booster, ShoulderWeaponRight, 
	ShoulderWeaponLeft, HandWeaponRight,HandWeaponLeft}
