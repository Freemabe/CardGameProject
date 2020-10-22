using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFetch : MonoBehaviour
{
	private bool isEmpty = true;
	public PartSlot partSlot1;
	public GameObject partPool;


    // Update is called once per frame
    void Update()
    {
      if (isEmpty)
      {
        foreach(GameObject part in partPool.GetComponent<Partslist>().partlist)
        {
            if (part.GetComponent<PartDisplay>().part.partSlot == partSlot1)
            {
                part.transform.SetParent(this.transform, false);
                part.transform.position = this.transform.position;
                isEmpty = false;
            }
        }
      }
    }
}
