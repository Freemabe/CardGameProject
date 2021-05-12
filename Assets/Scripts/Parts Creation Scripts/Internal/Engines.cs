using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Engine", menuName = "Part/Engine")]
public class Engines : Parts{

	public int energyRequired;
	public int outputPower;
	public override Dictionary<string,int> PublicDisplayInfo()
	{
		Dictionary<string, int> InfoDict = new Dictionary<string,int>();
		InfoDict.Add("Weight", weight);
		InfoDict.Add("Energy Required", energyRequired);
		InfoDict.Add("Output Power", outputPower);
		
	


		return InfoDict;
	}

}
