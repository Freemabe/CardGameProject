using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Torso", menuName = "Part/Torso")]
public class Torso : Body
{
	public int heatDisapation;
	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Structure Points", structurePoints);
		InfoDict.Add("Armor Points", armorPoints);
		InfoDict.Add("Armor Toughness", armorToughness);
		InfoDict.Add("Head Disapation", heatDisapation);

	


		return InfoDict;
	}
}
