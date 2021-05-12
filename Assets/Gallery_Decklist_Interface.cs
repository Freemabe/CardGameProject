using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gallery_Decklist_Interface : MonoBehaviour
{
    public GameObject contentFrame;

    public void OnClick()
    {
    	
    	Card card = this.GetComponent<CardDisplay>().card;
    	Debug.Log(card.name);
    	contentFrame.GetComponent<ContentFrame>().decklist.UpdateDictionary(true, card);
    	contentFrame.GetComponent<ContentFrame>().UpdateInfo();
    }

}
