using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectCast : MonoBehaviour
{
    public static void CorrectCasts(Parts currentPart)
    {
    	if(currentPart.partSlot == PartSlot.Head)
    	{
    		currentPart = (Head) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.LeftArm)
    	{
    		currentPart = (LeftArms) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.RightArm)
    	{
    		currentPart = (RightArms) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.LeftLeg)
    	{
    		currentPart = (LeftLegs) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.RightLeg)
    	{
    		currentPart = (RightLegs) currentPart;

    	 }

    	if(currentPart.partSlot == PartSlot.Torso)
    	{
    		currentPart = (Torso) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.Engine)
    	{
    		currentPart = (Engines) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.Generator)
    	{
    		currentPart = (Generators) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.Booster)
    	{
    		currentPart = (Boosters) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.ShoulderWeaponRight)
    	{
    		currentPart = (Weapons) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.HandWeaponRight)
    	{
    		currentPart = (Weapons) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.HandWeaponLeft)
    	{
    		currentPart = (Weapons) currentPart;
    		
    	}

    	if(currentPart.partSlot == PartSlot.ShoulderWeaponLeft)
    	{
    		currentPart = (Weapons) currentPart;
    		
    	}
    }
}
