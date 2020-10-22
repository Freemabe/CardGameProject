using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partslist : MonoBehaviour
{
	public List<GameObject> partlist = new List<GameObject>();
	
	private List<string>weaponList = new List<string>{"ShoulderWeaponRight",
				"ShoulderWeaponLeft", "HandWeaponRight","HandWeaponLeft"};
 	private List<string>legList = new List<string>{"LeftLeg","RightLeg"};
 	private List<string>internalList = new List<string>{"Engine","Generator","Booster"};
	
	public Parts[] temparray;

	public GameObject weaponPrefab;
	public GameObject armOrHeadPrefab;
	public GameObject torsoPrefab;
	public GameObject legPrefab;
	public GameObject internalPrefab;

	GameObject placeholder;

	public void Start()
	{
		//load in a an array of parts (currently cheating)

		//instantiate those parts in the list into game objects
		foreach (Parts part in temparray)
		{
			if (weaponList.Contains(part.partSlot.ToString()))
			{
				//Debug.Log(part + "created" + "type is" +part.partSlot);
				//Debug.Log("part.partSlot type is " + part.partSlot.ToString());
				GameObject placeholder = Instantiate(weaponPrefab);
				placeholder.GetComponent<PartDisplay>().part = part;
				placeholder.transform.SetParent(this.transform, false);
				partlist.Add(placeholder);
			}
			else if (part.partSlot.ToString() == "Torso")
	    	{
				//Debug.Log(part + "created" + "type is" +part.partSlot);
				//Debug.Log("part.partSlot type is " + part.partSlot.ToString());
				GameObject placeholder = Instantiate(torsoPrefab);
				placeholder.GetComponent<PartDisplay>().part = part;
				placeholder.transform.SetParent(this.transform, false);
				partlist.Add(placeholder);
			}
			else if (legList.Contains(part.partSlot.ToString()))
	    	{
				//Debug.Log(part + "created" + "type is" +part.partSlot);
				//Debug.Log("part.partSlot type is " + part.partSlot.ToString());
				GameObject placeholder = Instantiate(legPrefab);
				placeholder.GetComponent<PartDisplay>().part = part;
				placeholder.transform.SetParent(this.transform, false);
				partlist.Add(placeholder);
			}
			else if (internalList.Contains(part.partSlot.ToString()))
	    	{
				//Debug.Log(part + "created" + "type is" +part.partSlot);
				//Debug.Log("part.partSlot type is " + part.partSlot.ToString());
				GameObject placeholder = Instantiate(internalPrefab);
				placeholder.GetComponent<PartDisplay>().part = part;
				placeholder.transform.SetParent(this.transform, false);
				partlist.Add(placeholder);
			}
			else
	    	{
				//Debug.Log(part + "created" + "type is" +part.partSlot);
				//Debug.Log("part.partSlot type is " + part.partSlot.ToString());
				GameObject placeholder = Instantiate(armOrHeadPrefab);
				placeholder.GetComponent<PartDisplay>().part = part;
				placeholder.transform.SetParent(this.transform, false);
				partlist.Add(placeholder);
			}

		}
	}
	private void MakePart(GameObject placeholder, Parts part){
		//Debug.Log(part + "created" + "type is" +part.partSlot);
		//Debug.Log("part.partSlot type is " + part.partSlot.ToString());
		placeholder = Instantiate(armOrHeadPrefab);
		placeholder.GetComponent<PartDisplay>().part = part;
		placeholder.transform.SetParent(this.transform, false);
	}
}
