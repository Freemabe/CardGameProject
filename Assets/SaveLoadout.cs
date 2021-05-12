using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadout : MonoBehaviour
{
    public MechInventory mechInventory;
    public string loadoutName;

    public void Onclick()
    {
    	ES3.Save(loadoutName, mechInventory, "MechInventory/PlayerInventory.es3");
    }
}
