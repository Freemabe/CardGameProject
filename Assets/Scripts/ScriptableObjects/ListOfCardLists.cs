using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListOfCardLists", menuName = "List/ListOfCardLists")]
public class ListOfCardLists : ScriptableObject
{
    public List<CardList> listOfCardLists = new List<CardList>();
    public int counter = 0;
    public int subcounter = 0;

}
