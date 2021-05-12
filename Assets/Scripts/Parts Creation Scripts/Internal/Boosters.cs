using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Booster", menuName = "Part/Boosters")]
public class Boosters : Parts
{
	public int energyRequired;
	public int thrust;
	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Energy Required", energyRequired);
		InfoDict.Add("Thrust", thrust);
		
	


		return InfoDict;
	}
}
