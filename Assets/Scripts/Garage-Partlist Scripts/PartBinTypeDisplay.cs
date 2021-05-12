using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartBinTypeDisplay : MonoBehaviour
{
    public ListOfPartLists ListOfPartLists;

    public GameObject partTypeSelectorText;

    public GameObject partSelector;

    public BoolHolder leftRigthBool;

    public void LeftArrow()
    {
    	if (ListOfPartLists.counter == 0)
    	{
    		ListOfPartLists.counter = ListOfPartLists.ListOfPartTypeLists.Count-1;
    		UpdateText(0);
    	}
    	else
    	{
    		UpdateText(-1);
    	}

    	
    }

    public void RigthArrow()
    {
    	if (ListOfPartLists.counter == ListOfPartLists.ListOfPartTypeLists.Count-1)
    	{
    		ListOfPartLists.counter = 0;
    		UpdateText(0);
    	}
    	else
    	{
    		UpdateText(1);
    	}
    	
    }

    public void UpdateText(int UpDown)
    {	

    	ListOfPartLists.subcounter = 0;
        leftRigthBool.boolValue = true;
    	ListOfPartLists.counter += UpDown;
    	partTypeSelectorText.GetComponent<TMPro.TextMeshProUGUI>().text = ListOfPartLists.ListOfPartTypeLists[ListOfPartLists.counter].name.ToString();
        partSelector.GetComponent<PartBinPartDisplay>().UpdateInfo(0);
    }

    public void Start()
    {
        ListOfPartLists.counter = 0;
        ListOfPartLists.subcounter = 0;
    	UpdateText(0);
    }
}
