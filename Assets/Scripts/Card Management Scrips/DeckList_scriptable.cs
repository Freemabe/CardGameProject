using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New DeckList", menuName = "List/DeckList") ]
public class DeckList_scriptable : ScriptableObject
{
    public Dictionary<int, (Card, int)> deckList = new Dictionary<int, (Card, int)>();
    private int cardCount=0;
    public int SearchDictionary(Card card)
    {
    	int tempcount = 0;
    	for(int i = 0; i<deckList.Count; i++)
    	{
    		if(deckList.ContainsKey(i) && deckList[i].Item1 == card)
    		{
    			tempcount = deckList[i].Item2;
    		}
    	}
    	return tempcount;
    }

    public void UpdateDictionary(bool increase, Card card)
    {
    	
    	//determine if adding or removing cards
    	if(increase)
    	{
    		int initialLength = deckList.Count;
    		for(int i = 0; i <= initialLength; i++)
    		{
                cardCount = 0;
                foreach (KeyValuePair<int, (Card, int)> kvp in deckList)
                {
                    cardCount += kvp.Value.Item2;
                }

    			if (deckList.ContainsKey(i) && deckList[i].Item1 == card && cardCount < 40)
    			{
    				if(deckList[i].Item2 < 4)
    				{
    					IncreaseCard(i);	
    				}
    				break;	
    			}
    			
    			else if (i == deckList.Count  && cardCount < 40)
    			{
    				Addcard(i, card);
    				break;
    			}
                
    		}
    	}
    	else
    	{
    		for(int i = 0; i < deckList.Count; i++)
    		{
    			if (deckList[i].Item1 == card && deckList[i].Item2 > 1)
    			{
    				DecreaseCard(i);
    			}
    			else if (deckList[i].Item1 == card && deckList[i].Item2 <= 1)
    			{
    				RemoveCard(i);
    			}
    		}
    	}
    }
    private void Addcard(int cardID, Card card)
    {

    	deckList.Add(cardID, (card, 1));

    }

    

    private void IncreaseCard(int cardID)
    {
    	Card card = deckList[cardID].Item1;
    	int amount = deckList[cardID].Item2;

		amount += 1;
		deckList[cardID] = (card, amount);

    }

    private void DecreaseCard(int cardID)
    {
    	Card card = deckList[cardID].Item1;
    	int amount = deckList[cardID].Item2;
		amount -= 1;
		deckList[cardID] = (card, amount);
    }

    private void RemoveCard(int cardID)
    {
    	for(int i = cardID; i < deckList.Count; i++)
    	{
    		
    		if(i+1 == deckList.Count)
    		{
    			deckList.Remove(i);
    		}
    		else
    		{
    			deckList[i] = (deckList[i+1].Item1,deckList[i+1].Item2);
    		}
    		
    	}
    }

    
}

