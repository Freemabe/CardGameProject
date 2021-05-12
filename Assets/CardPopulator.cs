using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPopulator : MonoBehaviour
{
   public List<GameObject> cardSlots = new List<GameObject>();

   public void PopulateCards(CardList CardList, int counter, int startIndex = 0, int terminator = 0)
   {
	   	if (terminator == 1)
	   	{
	   		for ( int i = startIndex; i<10; i ++)
	   		{
	   			cardSlots[i].SetActive(false);
	   		}
	   	}

	   	else{
	   		for ( int i = 0; i<10; i ++)
	   		{
	   			cardSlots[i].SetActive(true);
	   		}
	   		if (startIndex == 0)
	   		{
				for( int i = 0; i<10&&i<(CardList.cardList.Count - counter); i ++)
				{
					cardSlots[i].GetComponent<CardDisplay>().card = CardList.cardList[i+counter];
					cardSlots[i].GetComponent<CardDisplay>().UpdateCard();
				}
			}
			else if (startIndex !=0);
			{
				for( int i = startIndex; i<10&&i<(CardList.cardList.Count - counter); i ++)
				{
					cardSlots[i].GetComponent<CardDisplay>().card = CardList.cardList[i-startIndex+counter];
					cardSlots[i].GetComponent<CardDisplay>().UpdateCard();
				}
			}
		}
   }
}
