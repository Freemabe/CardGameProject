using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddRemoveCard : MonoBehaviour
{

    
    

    public GameObject content;
	public GameObject parent;

    public DeckList_scriptable decklist;
    public Card card;


    public void Start()
    {
    	decklist = content.GetComponent<ContentFrame>().decklist;
    	card = parent.GetComponent<Decklist_Card_Updater>().card;
    }
    public void AddCard()
    {
    	decklist = content.GetComponent<ContentFrame>().decklist;
    	card = parent.GetComponent<Decklist_Card_Updater>().card;
		decklist.UpdateDictionary(true, card);
		
		content.GetComponent<ContentFrame>().UpdateInfo();
	}

    public void RemoveCard()
    {
    	decklist = content.GetComponent<ContentFrame>().decklist;
    	card = parent.GetComponent<Decklist_Card_Updater>().card;
		decklist.UpdateDictionary(false, card);
	
		content.GetComponent<ContentFrame>().UpdateInfo();
    }
}
