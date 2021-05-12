using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New RightArm", menuName = "Part/RightArm")]
public class RightArms : Body
{
	public int tracking;

	public LeftArms pairPart;
	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Structure Points", structurePoints);
		InfoDict.Add("Armor Points", armorPoints);
		InfoDict.Add("Armor Toughness", armorToughness);
		InfoDict.Add("Target Tracking", tracking);
	


		return InfoDict;
	}
}
