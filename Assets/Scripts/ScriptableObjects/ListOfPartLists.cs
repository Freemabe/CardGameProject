using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListOfPartLists", menuName = "List/ListOfPartLists")]
public class ListOfPartLists : ScriptableObject
{
    public List<PartTypeList> ListOfPartTypeLists = new List<PartTypeList>();
    public int counter = 0;
    public int subcounter = 0;
}
