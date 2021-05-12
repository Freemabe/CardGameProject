using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    public GameObject parentUI;

    public void Onclick()
    {
    	parentUI.SetActive(false);
    }
}
