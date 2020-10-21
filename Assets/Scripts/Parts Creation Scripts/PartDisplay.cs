using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartDisplay : MonoBehaviour{

	public Weapons weapon;
	public Image artworkImage;


	void Start(){
		artworkImage.sprite = weapon.Icon;
	}
}
