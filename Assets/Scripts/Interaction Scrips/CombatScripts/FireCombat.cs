using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: fire a percentage of shells at targets porpotional to the times they clicked or fire the required shells and then random otherwise?
//add back in dmg from the untitled tab
public class FireCombat : MonoBehaviour
{
	public CombatList combatList;
	private int childNumber;
	//stuff needed for accuracy method
	public MechInventory enemyInv;
	public MechInventory playerInv;

	public StatusHolder enemyStatusHolder;

	private int enemyWeight;
	private int enemyECM;
	private int enemyThrust;
	private int enemyMovespeed;

	private int playerTracking;
	private int playEcmCounter;
	private int playerGunBonuses;
	private int enemyWeightCapacity;
	//

	public void OnClick()
	{
		List<GameObject> combatListBodyPool = new List<GameObject>(combatList.bodyPool.Keys);
		if (combatList.weaponPool.Count == 1 && combatListBodyPool.Count > 0) 
		{
			
			int maxSize = combatList.maxSize;
			float toHitRoll = Random.Range(0.0f,100.0f);
			Weapons shootingWeapon = (Weapons) combatList.weaponPool[0].GetComponent<PartDisplay>().part;
			float evasionAmount = Evasion(shootingWeapon);
			FireEffect(maxSize, evasionAmount);
			UpkeepEffect(combatListBodyPool);
		}
	}


	private void FireEffect(int maxSize, float evasionAmount)
	{
		
		while(maxSize>0 && combatList.weaponPool[0].GetComponent<WeaponStats>().currentAmmo > 0)
		{
			foreach(KeyValuePair<GameObject,int> kvp in combatList.bodyPool)
			{
				for (int i = 0 ; i < kvp.Value; i++)
				{	
					float toHitRoll = Random.Range(0.0f,100.0f);

					if (toHitRoll>=evasionAmount*100)
					{
						int dmg = combatList.weaponPool[0].GetComponent<WeaponStats>().Attack();
						kvp.Key.GetComponent<BodyStats>().TakeDamage(dmg);
						Debug.Log("You hit");
					}
					else
					{
						Debug.Log("You missed");
					}
					
					maxSize -= 1;
					combatList.weaponPool[0].GetComponent<WeaponStats>().DrainAmmo();
					if(maxSize == 0)//have you fired all of your shots- check
					{
						break;
					}
					if(combatList.weaponPool[0].GetComponent<WeaponStats>().currentAmmo == 0)// are you out of ammo and we are going to conserve cpu power- check
					{
						break;
					}
				}
			}
		}
	}
	private void UpkeepEffect(List<GameObject> combatListBodyPool)
	{
		for (int i =0 ; i <combatList.bodyPool.Count; i++)
			{
				GameObject part = combatListBodyPool[i];
				childNumber = part.transform.childCount;
				for (int j =0 ; j <childNumber; j++)
				{
					if (part.transform.GetChild(j).name.Contains("Crosshairs(Clone)"))
					{
						Destroy(part.transform.GetChild(j).gameObject);
					}
				}
			}
		combatList.weaponPool[0].GetComponent<AddWeaponToCombatPool>().hasFiredThisTurn = true;
		combatList.weaponPool = new List<GameObject>();
		combatList.bodyPool = new Dictionary<GameObject,int>();
		combatList.currentSum = 0;
		Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
	}
	public float Evasion(Weapons weapon)
	{
		//determine weight and if overweight
		enemyWeight = enemyInv.Weight();
		LeftLegs enemyLeftLeg = (LeftLegs) enemyInv.LeftLeg;
		RightLegs enemyRightLeg = (RightLegs) enemyInv.RightLeg;


		//see what legs are working and collect the weight capacity from them
		if(enemyStatusHolder.isLeftLegDestroyed)
		{
			enemyWeightCapacity = enemyRightLeg.weightCapacity;
		}
		else if(enemyStatusHolder.isRightLegDestroyed)
		{
			enemyWeightCapacity = enemyLeftLeg.weightCapacity;
		}
		else
		{
			enemyWeightCapacity = enemyLeftLeg.weightCapacity + enemyRightLeg.weightCapacity;
		}


		//see if the target is currently overweight
		if(enemyWeight>enemyWeightCapacity)
		{
			enemyStatusHolder.isOverweight = true;
		}
		else if (enemyWeight<=enemyWeightCapacity)
		{
			enemyStatusHolder.isOverweight = false;
		}


		//When I impliment ECM uncomment and do stuff
		//enemyECM = enemyInv.Head.ECM;
		//playEcmCounter = playerInv.Head.EcmCounter;

		//determine thrust and thrust to weight ratio;
		Boosters enemyBooster = (Boosters) enemyInv.Booster;
		enemyThrust = enemyBooster.thrust;
		float enemyThrustToWeight =(float) enemyThrust/enemyWeight;


		//determine movespeed
		enemyMovespeed = (enemyLeftLeg.moveSpeed + enemyRightLeg.moveSpeed)/2;
		float enemyMovespeedLog = Mathf.Log(enemyMovespeed,10);
		float enemyMovespeedEvasion = (float) enemyMovespeedLog/7;


		//determine tracking and gun bonuses
		//playerGunBonuses = weapon.accuracyBonus;
		RightArms playerRightArm = (RightArms) playerInv.RightArm;
		LeftArms playerLeftArm = (LeftArms) playerInv.LeftArm;
		Weapons playerWeapon = weapon;
		if(playerWeapon.partSlot.ToString() == "HandWeaponRight")
		{
			playerTracking = playerRightArm.tracking;
			//playerTracking += playerGunBonuses;
			Debug.Log("Righthand shooting");
		}
		else if(playerWeapon.partSlot.ToString() == "HandWeaponLeft")
		{
			playerTracking = playerLeftArm.tracking;
			//playerTracking += playerGunBonuses;
			Debug.Log("Lefthand shooting");
		}
		else
		{
			playerTracking = 0;
			//playerTracking += playerGunBonuses;
			Debug.Log("Shoulder shooting");
		}
		float playerTrackingEvasion =(float) playerTracking/100;


		//sum all evasions together
		float returnEvasionValue = 0f;
		if(!enemyStatusHolder.isOverweight)
		{
			returnEvasionValue += enemyMovespeedEvasion;
		}
		if (enemyStatusHolder.isBoosting)
		{
			returnEvasionValue += enemyThrustToWeight;
		}
		returnEvasionValue -= playerTrackingEvasion;
		Debug.Log("Is overweight?: " + enemyStatusHolder.isOverweight);
		Debug.Log("Enemy Mech Weight: " +enemyWeight);
		Debug.Log("MoveSpeed evasion: " + enemyMovespeedEvasion);
		Debug.Log("Thrust Evasion: " + enemyThrustToWeight);
		Debug.Log("Thrust Raw: " + enemyThrust);
		Debug.Log("Player Tracking: " + playerTrackingEvasion);
		Debug.Log("Player Tracking Raw: " + playerTracking);
		Debug.Log("returnEvasionValue: " +returnEvasionValue);
		return returnEvasionValue; 
	}
}
