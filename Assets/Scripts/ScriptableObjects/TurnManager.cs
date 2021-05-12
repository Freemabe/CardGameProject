using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TurnManager : ScriptableObject
{
	public int turn = 0;
	public bool playerTurn = true;
}
