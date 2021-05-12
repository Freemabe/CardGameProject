using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostTabScript : MonoBehaviour
{
	public ListOfCardLists listOfCardListsMinions;
	public ListOfCardLists listOfCardListsSpells;

	[Tooltip("The number of sublists in your list above, minus 1")]
	public int numberOfLists;//number of sub lists in the the above two lists, should always be the same, and either be 0 (reresenting 1 list, confusing i know) or
	//the max number of lists (currently 3, because we have 4 different cost lists.)

	public GameObject cardGalleryFrame;
	public GameObject spellFrame;
	public GameObject minionFrame;

	public void OnCLick()
	{
		if(minionFrame.activeInHierarchy == true)
		{
			cardGalleryFrame.GetComponent<GalleryFrameController>().SwitchCostTabMinions(listOfCardListsMinions, numberOfLists);
		}

		else if (spellFrame.activeInHierarchy == true)
		{
			cardGalleryFrame.GetComponent<GalleryFrameController>().SwitchCostTabSpells(listOfCardListsSpells, numberOfLists);
		}
	}
}
