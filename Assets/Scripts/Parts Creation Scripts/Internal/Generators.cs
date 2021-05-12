using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Generator", menuName = "Part/Generators")]
public class Generators : Parts
{
	public int energyOutput;
	public int energyStorageCapcity;
	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Energy Output", energyOutput);
		InfoDict.Add("Energy Storage Capacity", energyStorageCapcity);
	
		
	


		return InfoDict;
	}
	
}

