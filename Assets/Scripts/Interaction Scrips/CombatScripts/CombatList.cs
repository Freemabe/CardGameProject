using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Combat List", menuName = "List/CombatList")]
public class CombatList : ScriptableObject
{	
	public int maxSize = 1; //current weapon fire rate
	public int currentSum= 0;//current number of total shots allocated already
	public Dictionary<GameObject,int> bodyPool = new Dictionary<GameObject,int>();
	public List<GameObject> weaponPool = new List<GameObject>();
}
