using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

public class Decklist : MonoBehaviour
{
	public List<Card> decklist = new List<Card>();
	public GameObject minionPrefab;
	public GameObject spellPrefab;
	GameObject placeholder;
	
	void Start(){
		Card[] importedCards = Resources.LoadAll<Card>("Cards");
		for (int i = 0; i<importedCards.Length; i++)
		{
			decklist.Add(importedCards[i]);
		}
		for (int i = 0; i<decklist.Count; i++)
		{
			if (decklist[i].cardType.ToString() == "Minion")
			{
    			GameObject placeholder = Instantiate(minionPrefab);
    			placeholder.GetComponent<CardDisplay>().card =(Minion) decklist[i];
    			placeholder.transform.SetParent(this.transform, false);
    		}
    		else if (decklist[i].cardType.ToString() == "Spell")
    		{
    			GameObject placeholder = Instantiate(spellPrefab);
    			placeholder.GetComponent<CardDisplay>().card =(Spell) decklist[i];
    			placeholder.transform.SetParent(this.transform, false);
    		}
    	}
	}
 }
