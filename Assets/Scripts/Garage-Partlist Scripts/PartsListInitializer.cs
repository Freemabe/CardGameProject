using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsListInitializer : MonoBehaviour
{
	public ListOfPartLists listOfLists;
    public void Start()
    {
    	for (int i=0; i<listOfLists.ListOfPartTypeLists.Count; i++)
    	{
    		
    		listOfLists.ListOfPartTypeLists[i].GrabParts();
    	}
    	
    }
}
