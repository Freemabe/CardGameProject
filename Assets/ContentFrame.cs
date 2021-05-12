using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentFrame : MonoBehaviour
{
	public DeckList_scriptable decklist; 
	

	public void Start()
	{
		UpdateInfo();
	}
	public void UpdateInfo()
	{
		int i = 0;
		foreach(Transform child in this.transform)
		{
			
			if (decklist.deckList.ContainsKey(i))
			{
				GameObject kid = child.gameObject;
				kid.SetActive(true);
				kid.GetComponent<Decklist_Card_Updater>().card = decklist.deckList[i].Item1;
				kid.GetComponent<Decklist_Card_Updater>().numberOfCards = decklist.deckList[i].Item2;
				kid.GetComponent<Decklist_Card_Updater>().UpdateInfo();
			}
			else
			{
				
				child.gameObject.SetActive(false);
				
			}
			i+= 1;
						
		}
	}


}
