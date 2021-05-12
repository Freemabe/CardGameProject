using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartBinPartDisplay : MonoBehaviour
{
    public ListOfPartLists ListOfPartLists;

    public GameObject partSelectorText;

    public Image picture;

    public GameObject description;

    public GameObject partStatsGameObject;

    public GameObject activeDisplayPanel;

    public BoolHolder leftRightBool; // will tell us to display left or right items.
    
    PartTypeList ListPosition()
    {
        return ListOfPartLists.ListOfPartTypeLists[ListOfPartLists.counter];
    }


    public void LeftArrow()
    {
    	if (ListOfPartLists.subcounter == 0)
    	{
    		ListOfPartLists.subcounter = ListPosition().partsList.Count-1;
    		UpdateInfo(0);
    	}
    	else
    	{
    		UpdateInfo(-1);
    	}
    	
    }

    public void RigthArrow()
    {
    	if (ListOfPartLists.subcounter == ListPosition().partsList.Count-1)
    	{
    		ListOfPartLists.subcounter = 0;
    		UpdateInfo(0);
    	}
    	else
    	{
    		UpdateInfo(1);
    	}
    	
    }

    public void UpdateInfo(int UpDown)
    {	
        
        //updates the info and checks if we are on arms or legs for special considerations
    	ListOfPartLists.subcounter += UpDown;
        PanelSorter();
        if (ListPosition().name.ToString() == "Arms" || ListPosition().name.ToString() == "Legs")
        {
            //aka if bool value is true we display left items if its false we display right items
            if (leftRightBool.boolValue)
            {
                partSelectorText.GetComponent<TMPro.TextMeshProUGUI>().text = ListPosition().partsList[ListOfPartLists.subcounter].name.ToString();
                picture.sprite = ListPosition().partsList[ListOfPartLists.subcounter].Icon;
                description.GetComponent<TMPro.TextMeshProUGUI>().text = ListPosition().partsList[ListOfPartLists.subcounter].description;
            }
            else
            {
                // in the case that the bool is false we are on the right sided items
                //then we filter to see if we have arms or legs
                //finally we display the paired part on screen
                if (ListPosition().name.ToString() == "Arms")
                {
                    LeftArms Part = (LeftArms) ListPosition().partsList[ListOfPartLists.subcounter];
                    partSelectorText.GetComponent<TMPro.TextMeshProUGUI>().text = Part.pairPart.name.ToString();
                    picture.sprite = Part.pairPart.Icon;
                    description.GetComponent<TMPro.TextMeshProUGUI>().text = Part.pairPart.description;
                }
                else
                {
                    LeftLegs Part = (LeftLegs) ListPosition().partsList[ListOfPartLists.subcounter];
                    partSelectorText.GetComponent<TMPro.TextMeshProUGUI>().text = Part.pairPart.name.ToString();
                    picture.sprite = Part.pairPart.Icon;
                    description.GetComponent<TMPro.TextMeshProUGUI>().text = Part.pairPart.description;
                }
                
            } 
        }
        // if its not arms or legs we just load the values
        else
        {
            partSelectorText.GetComponent<TMPro.TextMeshProUGUI>().text = ListPosition().partsList[ListOfPartLists.subcounter].name.ToString();
            picture.sprite = ListPosition().partsList[ListOfPartLists.subcounter].Icon;
            description.GetComponent<TMPro.TextMeshProUGUI>().text = ListPosition().partsList[ListOfPartLists.subcounter].description;
        }
        
    }

    public void Start()
    {
    	UpdateInfo(0);
    }


    public void LeftRightBoolSwitch()
    {
        if (leftRightBool.boolValue)
        {
            leftRightBool.boolValue = false;
        }
        else
        {
            leftRightBool.boolValue = true;
        }
    }

    public void PanelSorter()
    {   
        activeDisplayPanel.SetActive(false);
        activeDisplayPanel = partStatsGameObject.GetComponent<DisplayPanelList>().listOfDisplayPanels[ListOfPartLists.counter];
        activeDisplayPanel.SetActive(true);
        //finds scripts from list of display panels and matchs them to current part type counter value
        
        if(ListOfPartLists.counter == 0)
        {
            activeDisplayPanel.GetComponent<DisplayPanelArms>().part = (LeftArms) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelArms>().UpdateText();

        }
        else if(ListOfPartLists.counter == 1)
        {
            activeDisplayPanel.GetComponent<DisplayPanelBooster>().part = (Boosters) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelBooster>().UpdateText();
        }
        else if(ListOfPartLists.counter == 2)
        {
            activeDisplayPanel.GetComponent<DisplayPanelEngine>().part = (Engines) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelEngine>().UpdateText();
        }
        else if(ListOfPartLists.counter == 3)
        {
            activeDisplayPanel.GetComponent<DisplayPanelGenerator>().part = (Generators) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelGenerator>().UpdateText();

        }
        else if(ListOfPartLists.counter == 4)
        {
            activeDisplayPanel.GetComponent<DisplayPanelHead>().part = (Head) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelHead>().UpdateText();
        }
        else if(ListOfPartLists.counter == 5 || ListOfPartLists.counter == 6 || ListOfPartLists.counter == 8 || ListOfPartLists.counter == 9)
        {
            activeDisplayPanel.GetComponent<DisplayPanelWeapon>().part = (Weapons) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelWeapon>().UpdateText();
        }
        else if(ListOfPartLists.counter == 7)
        {
            activeDisplayPanel.GetComponent<DisplayPanelLegs>().part = (LeftLegs) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelLegs>().UpdateText();
        }
        else if(ListOfPartLists.counter == 10)
        {            activeDisplayPanel.GetComponent<DisplayPanelTorso>().part = (Torso) ListPosition().partsList[ListOfPartLists.subcounter];
            activeDisplayPanel.GetComponent<DisplayPanelTorso>().UpdateText();
        }
    }
}
