﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//https://www.youtube.com/watch?v=0-dUB52eEMk&list=PLCbP9KGntfcFbPnUSuQXLKoaJ8MiWBSk6
public class DrawCards : MonoBehaviour
{
	public GameObject deck;

	public GameObject Player_hand_object;
	public GameObject Enemy_hand_object;


    public void OnClick()
    {
    	
	    	Transform playerCard = deck.transform.GetChild(Random.Range(0,deck.transform.childCount));
	    	playerCard.transform.SetParent(Player_hand_object.transform, false);

	    	Transform enemyCard = deck.transform.GetChild(Random.Range(0,deck.transform.childCount));
	    	enemyCard.transform.SetParent(Enemy_hand_object.transform, false);
    	
    }

}
