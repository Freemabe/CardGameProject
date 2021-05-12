using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Head", menuName = "Part/Head")]
public class Head : Body
{
	public int sensorAbility;
	public int ecmCounter;
	public int coordination;

	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Structure Points", structurePoints);
		InfoDict.Add("Armor Points", armorPoints);
		InfoDict.Add("Armor Toughness", armorToughness);
		InfoDict.Add("SensorAbility", sensorAbility);
		InfoDict.Add("ECM Counter", ecmCounter);
		InfoDict.Add("Coordination", coordination);


		return InfoDict;
	}
}