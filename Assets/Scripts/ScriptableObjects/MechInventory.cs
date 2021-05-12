using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New MechInventory", menuName= "New MechInventory")]
public class MechInventory : ScriptableObject
{
    public Parts Booster;
    public Parts Engine;
    public Parts Generator;
    public Parts Head;
    public Parts LeftArm;
    public Parts HandWeaponLeft;
    public Parts LeftLeg;
    public Parts ShoulderWeaponLeft;
    public Parts RightArm;
    public Parts HandWeaponRight;
    public Parts RightLeg;
    public Parts ShoulderWeaponRight;
    public Parts Torso;

    public int Weight()
    {
        int weight = 0;
        weight += Booster.weight;
        weight += Engine.weight;
        weight += Generator.weight;
        weight += Head.weight;
        weight += LeftArm.weight;
        weight += HandWeaponLeft.weight;
        weight += LeftLeg.weight;
        weight += ShoulderWeaponLeft.weight;
        weight += RightArm.weight;
        weight += HandWeaponRight.weight;
        weight += RightLeg.weight;
        weight += ShoulderWeaponRight.weight;
        weight += Torso.weight;
        return weight;

    }
}
