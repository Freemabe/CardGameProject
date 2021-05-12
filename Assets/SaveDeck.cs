using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDeck : MonoBehaviour
{
   public DeckList_scriptable decklist;

   public string saveName;

   public void OnClick()
   {
  		
   		ES3.Save(saveName, decklist, "Decklist/PlayerDecklist.es3");
   }
}
