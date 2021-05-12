using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDeck : MonoBehaviour
{
	public DeckList_scriptable decklist;
	private DeckList_scriptable defaultdecklist;
	public string saveName;
	public GameObject contentFrame;

	public void OnClick()
	{
		
		decklist = ES3.Load(saveName, "Decklist/PlayerDecklist.es3", defaultdecklist);
		contentFrame.GetComponent<ContentFrame>().UpdateInfo();
	}
}
