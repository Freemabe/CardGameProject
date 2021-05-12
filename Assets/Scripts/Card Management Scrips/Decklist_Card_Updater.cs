using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;


public class Decklist_Card_Updater : MonoBehaviour
{
    public TMP_Text cardName;
    public TMP_Text cardNumber;

    public Card card;
    public int numberOfCards;

    public GameObject content;

    public DeckList_scriptable decklist;



    public void Awake()
    {
    	decklist = content.GetComponent<ContentFrame>().decklist;
    }
    public void UpdateInfo()
    {
    	numberOfCards = decklist.SearchDictionary(card);
    	cardNumber.text = numberOfCards.ToString();
    	cardName.text = card.name;
    }
}
