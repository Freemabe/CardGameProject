using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New StatusHolder", menuName = "StatusHolder")]
public class StatusHolder : ScriptableObject
{
	public bool isOverweight;
	public bool isBoosting;
	public bool isLeftLegDestroyed;
	public bool isRightLegDestroyed;
	//add more statuses as they arrise
}

