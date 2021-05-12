using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldStarButton : MonoBehaviour
{
   public int saveSlot;

   public void OnClick()
   {
   	ES3.Save("SaveSlot", saveSlot, "MechInventory/saveSlot.es3");
   }
}
//will tell game what save slot to load automatically