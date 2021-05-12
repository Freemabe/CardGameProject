using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CardList", menuName = "List/CardList")]
public class CardList : ScriptableObject
{
   public string path;

	public List<Card> cardList = new List<Card>();

	public void GrabCards()
	{	cardList = new List<Card>();
		Card[] cardArray = Resources.LoadAll<Card>($"Cards/{path}");
		for (int i=0; i<cardArray.Length; i++)
		{
			cardList.Add(cardArray[i]);
			//Debug.Log("added a part" + partsList[i]);
		}
	}
}
