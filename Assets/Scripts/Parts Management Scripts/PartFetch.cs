using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFetch : MonoBehaviour
{
    public MechInventory mechInventory;
    public MechInventory defaultMechInventory;
    public PartSlot partSlot1;
    public bool isEmpty = true;

    public void Awake()
    {
        
        Fetch();
    }

    public void Fetch()
    {
        
        isEmpty = false;
        
        if(partSlot1 == PartSlot.Head)
        {
            this.GetComponent<BodyStats>().basePart = mechInventory.Head;
            this.GetComponent<PartDisplay>().part = mechInventory.Head;
            this.name = mechInventory.Head.name;
        }

        if(partSlot1 == PartSlot.LeftArm)
        {
            this.GetComponent<BodyStats>().basePart = mechInventory.LeftArm;
            this.GetComponent<PartDisplay>().part = mechInventory.LeftArm;
            this.name = mechInventory.LeftArm.name;
        }

        if(partSlot1 == PartSlot.RightArm)
        {
            this.GetComponent<BodyStats>().basePart = mechInventory.RightArm;
            this.GetComponent<PartDisplay>().part = mechInventory.RightArm;
            this.name = mechInventory.RightArm.name;
        }

        
        if(partSlot1 == PartSlot.LeftLeg)
        {
            this.GetComponent<BodyStats>().basePart = mechInventory.LeftLeg;
            this.GetComponent<PartDisplay>().part = mechInventory.LeftLeg;
            this.name = mechInventory.LeftLeg.name;
        }

        if(partSlot1 == PartSlot.RightLeg)
        {
            this.GetComponent<BodyStats>().basePart = mechInventory.RightLeg;
            this.GetComponent<PartDisplay>().part = mechInventory.RightLeg;
            this.name = mechInventory.RightLeg.name;
        }


        if(partSlot1 == PartSlot.Torso)
        {
            this.GetComponent<BodyStats>().basePart = mechInventory.Torso;
            this.GetComponent<PartDisplay>().part = mechInventory.Torso;
            this.name = mechInventory.Torso.name;
        }

        if(partSlot1 == PartSlot.Engine)
        {
            
            this.GetComponent<PartDisplay>().part = mechInventory.Engine;
            this.name = mechInventory.Engine.name;
        }

        if(partSlot1 == PartSlot.Generator)
        {
            
            this.GetComponent<PartDisplay>().part = mechInventory.Generator;
            this.name = mechInventory.Generator.name;
        }

        if(partSlot1 == PartSlot.Booster)
        {
            
            this.GetComponent<PartDisplay>().part = mechInventory.Booster;
            this.name = mechInventory.Booster.name;
        }

        if(partSlot1 == PartSlot.ShoulderWeaponRight)
        {
            this.GetComponent<WeaponStats>().weaponPart = mechInventory.ShoulderWeaponRight;
            this.GetComponent<PartDisplay>().part = mechInventory.ShoulderWeaponRight;
            this.name = mechInventory.ShoulderWeaponRight.name;
        }

        if(partSlot1 == PartSlot.HandWeaponRight)
        {
            this.GetComponent<WeaponStats>().weaponPart = mechInventory.HandWeaponRight;
            this.GetComponent<PartDisplay>().part = mechInventory.HandWeaponRight;
            this.name = mechInventory.HandWeaponRight.name;
        }

        if(partSlot1 == PartSlot.HandWeaponLeft)
        {
            this.GetComponent<WeaponStats>().weaponPart = mechInventory.HandWeaponLeft;
            this.GetComponent<PartDisplay>().part = mechInventory.HandWeaponLeft;
            this.name = mechInventory.HandWeaponLeft.name;
        }

        if(partSlot1 == PartSlot.ShoulderWeaponLeft)
        {
            this.GetComponent<WeaponStats>().weaponPart = mechInventory.ShoulderWeaponLeft;
            this.GetComponent<PartDisplay>().part = mechInventory.ShoulderWeaponLeft;
            this.name = mechInventory.ShoulderWeaponLeft.name;
        }

        this.GetComponent<PartDisplay>().UpdateInfo();
    }

}
