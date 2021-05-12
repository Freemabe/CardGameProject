using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartDisplay : MonoBehaviour{

	public Parts part;
	public Image artworkImage;

	void Start()
	{
		UpdateInfo();
	}
	public void UpdateInfo()
	{
		artworkImage.sprite = part.Icon;
	}
}
