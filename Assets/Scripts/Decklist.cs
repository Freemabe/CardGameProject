using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

public class Decklist : MonoBehaviour
{
	public List<Card> decklist = new List<Card>();
	public GameObject cardPrefab;
	GameObject placeholder;
	
	void Start(){
		Card[] importedCards = Resources.LoadAll<Card>("Cards");
		for (int i = 0; i<importedCards.Length; i++){
			decklist.Add(importedCards[i]);
		}
		for (int i = 0; i<decklist.Count; i++){
    		GameObject placeholder = Instantiate(cardPrefab);
    		placeholder.GetComponent<CardDisplay>().card = decklist[i];
    		placeholder.transform.SetParent(this.transform, false);
    	}
	}
 }
