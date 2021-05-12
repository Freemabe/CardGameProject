using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLoadout : MonoBehaviour
{
    public MechInventory mechInventory;
    public MechInventory defaultMechInventory;
    public string loadoutName;

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

    public void Onclick()
    {
    	mechInventory = ES3.Load(loadoutName, "MechInventory/PlayerInventory.es3", defaultMechInventory);
    	Head.GetComponent<PartFetch>().Fetch();
    	LeftArm.GetComponent<PartFetch>().Fetch();
    	RightArm.GetComponent<PartFetch>().Fetch();
    	LeftLeg.GetComponent<PartFetch>().Fetch();
    	RightLeg.GetComponent<PartFetch>().Fetch();
    	Torso.GetComponent<PartFetch>().Fetch();
    	Engine.GetComponent<PartFetch>().Fetch();
    	Generator.GetComponent<PartFetch>().Fetch();
		Booster.GetComponent<PartFetch>().Fetch();
		ShoulderWeaponRight.GetComponent<PartFetch>().Fetch();
		HandWeaponRight.GetComponent<PartFetch>().Fetch();
		HandWeaponLeft.GetComponent<PartFetch>().Fetch();
		ShoulderWeaponLeft.GetComponent<PartFetch>().Fetch();
    }
}
