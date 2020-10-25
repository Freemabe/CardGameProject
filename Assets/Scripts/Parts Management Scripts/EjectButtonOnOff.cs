using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjectButtonOnOff : MonoBehaviour
{
	public GameObject parent;

	bool ejectbool;

    // Update is called once per frame
    void Update()
    {
		ejectbool = parent.GetComponent<PartFetch>().isEmpty;
		if (!ejectbool)
		{
			this.GetComponent<Button>().interactable = true;
		}
		if (ejectbool)
		{
			this.GetComponent<Button>().interactable = false;
		}	        
    }
}
