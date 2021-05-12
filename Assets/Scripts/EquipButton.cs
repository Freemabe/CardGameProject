using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class EquipButton : MonoBehaviour
{
    public MechInventory mechInventory;
    public ListOfPartLists ListOfPartLists; 
    public GameObject Booster;
    public GameObject Engine;
    public GameObject Generator;
    public GameObject Head;
    public GameObject LeftArm;
    public GameObject HandWeaponLeft;
    public GameObject LeftLeg;
    public GameObject ShoulderWeaponLeft;
    public GameObject RightArm;
    public GameObject HandWeaponRight;
    public GameObject RightLeg;
    public GameObject Torso;
    public GameObject ShoulderWeaponRight;

    public void Equip()
    {
    	Parts currentPart = ListOfPartLists.ListOfPartTypeLists[ListOfPartLists.counter].partsList[ListOfPartLists.subcounter];

    	if(currentPart.partSlot == PartSlot.Head)
    	{
    		mechInventory.Head = (Head) currentPart;
    		Head.GetComponent<PartFetch>().Fetch();

    	}

    	if(currentPart.partSlot == PartSlot.LeftArm)
    	{
    		mechInventory.LeftArm = (LeftArms) currentPart;
    		LeftArms currentPart1 = (LeftArms) currentPart;
    		mechInventory.RightArm = (RightArms) currentPart1.pairPart;
    		LeftArm.GetComponent<PartFetch>().Fetch();
    		RightArm.GetComponent<PartFetch>().Fetch();
    	}

    	
    	if(currentPart.partSlot == PartSlot.LeftLeg)
    	{
    		mechInventory.LeftLeg = (LeftLegs) currentPart;
    		LeftLegs currentPart1 = (LeftLegs) currentPart;
    		mechInventory.RightLeg = currentPart1.pairPart;
    		LeftLeg.GetComponent<PartFetch>().Fetch();
    		RightLeg.GetComponent<PartFetch>().Fetch();
    	}


    	if(currentPart.partSlot == PartSlot.Torso)
    	{
    		mechInventory.Torso = (Torso) currentPart;
    		Torso.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.Engine)
    	{
    		mechInventory.Engine = (Engines) currentPart;
    		Engine.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.Generator)
    	{
    		mechInventory.Generator = (Generators) currentPart;
    		Generator.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.Booster)
    	{
    		mechInventory.Booster = (Boosters) currentPart;
    		Booster.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.ShoulderWeaponRight)
    	{
    		mechInventory.ShoulderWeaponRight = (Weapons) currentPart;
    		ShoulderWeaponRight.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.HandWeaponRight)
    	{
    		mechInventory.HandWeaponRight = (Weapons) currentPart;
    		HandWeaponRight.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.HandWeaponLeft)
    	{
    		mechInventory.HandWeaponLeft = (Weapons) currentPart;
    		HandWeaponLeft.GetComponent<PartFetch>().Fetch();
    	}

    	if(currentPart.partSlot == PartSlot.ShoulderWeaponLeft)
    	{
    		mechInventory.ShoulderWeaponLeft = (Weapons) currentPart;
    		ShoulderWeaponLeft.GetComponent<PartFetch>().Fetch();
    	}
    }   
}
