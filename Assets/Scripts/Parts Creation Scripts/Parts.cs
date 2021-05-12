using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Parts : ScriptableObject {

	new public string name = "New Items";
	public Sprite Icon;
	public Sprite destroyedIcon;
	public int weight;
	public PartSlot partSlot;
	[TextArea(5,10)]
	public string description;

	public virtual Dictionary<string, int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("weight", weight);
		return InfoDict;
	}
}


public enum PartSlot { Head, LeftArm, RightArm, LeftLeg, RightLeg, 
	Torso, Engine, Generator, Booster, ShoulderWeaponRight, 
	ShoulderWeaponLeft, HandWeaponRight,HandWeaponLeft}
