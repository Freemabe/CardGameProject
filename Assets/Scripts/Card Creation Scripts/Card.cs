using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=aPXvoWVabPY
public class Card : ScriptableObject {

	public new string name;
	public string description;

	public Sprite artwork;

	public int manaCost;

	public CardType cardType;
	//public int attack;
	//public int health;

}

public enum CardType { Minion, Spell}