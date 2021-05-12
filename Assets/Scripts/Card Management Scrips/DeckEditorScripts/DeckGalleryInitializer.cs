using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckGalleryInitializer : MonoBehaviour
{
	public ListOfCardLists listOfCardListsMinions;
	public ListOfCardLists listOfCardListsSpells;
    void Awake()
    {
        for (int i=0; i<listOfCardListsMinions.listOfCardLists.Count; i++)
    	{
    		
    		listOfCardListsMinions.listOfCardLists[i].GrabCards();
    	}
    	for (int i=0; i<listOfCardListsSpells.listOfCardLists.Count; i++)
    	{
    		
    		listOfCardListsSpells.listOfCardLists[i].GrabCards();
    	}
    }
}
