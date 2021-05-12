using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PartTypeList", menuName = "List/PartTypeList")]
public class PartTypeList : ScriptableObject
{
	public string path;

	public List<Parts> partsList = new List<Parts>();

	public void GrabParts()
	{	partsList = new List<Parts>();
		Parts[] partsArray = Resources.LoadAll<Parts>($"Parts/{path}");
		for (int i=0; i<partsArray.Length; i++)
		{
			partsList.Add(partsArray[i]);
			//Debug.Log("added a part" + partsList[i]);
		}
	}
}
