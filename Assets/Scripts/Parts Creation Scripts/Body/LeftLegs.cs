using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New LeftLeg", menuName = "Part/LeftLeg")]
public class LeftLegs : Body
{
	public int weightCapacity;
	public int moveSpeed;

	public RightLegs pairPart;
	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Structure Points", structurePoints);
		InfoDict.Add("Armor Points", armorPoints);
		InfoDict.Add("Armor Toughness", armorToughness);
		InfoDict.Add("Weight Capacity", weightCapacity);
		InfoDict.Add("Move Speed", moveSpeed);
	


		return InfoDict;
	}
}
