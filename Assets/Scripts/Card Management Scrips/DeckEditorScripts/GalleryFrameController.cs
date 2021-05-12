using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryFrameController : MonoBehaviour
{
    public GameObject spellFrame;
    public GameObject minionFrame;

    private int minionCounter;
    private int minionSubcounter;
    private int spellCounter;
    private int spellSubcounter;

    private int newIndex;
    private int lastSetMinions;
    private int lastSetSpells;

    public ListOfCardLists ListOfCardListsSpells;
    public ListOfCardLists ListOfCardListsMinions;
    //default preloaded value when scene starts
    public void Awake()
    {
    	ListOfCardListsMinions.counter = 0;
    	ListOfCardListsMinions.subcounter = 0;

    	ListOfCardListsSpells.counter = 0;
    	ListOfCardListsSpells.subcounter = 0;

        lastSetMinions = 3;
        lastSetSpells = 3;
    	
    	CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
        ListOfCardListsMinions.subcounter += 10;

    }
    

    public void IncreasePage()
    {
    	if (minionFrame.activeInHierarchy == true)
    	{
    		IncreasePageSubFunction(minionFrame,ListOfCardListsMinions, lastSetMinions);
    	}
    	else if (spellFrame.activeInHierarchy == true)
    	{
    		IncreasePageSubFunction(spellFrame,ListOfCardListsSpells, lastSetSpells);
    	}
    }
    
    public void DecreasePage()
    {
    	if (minionFrame.activeInHierarchy == true)
        {
            DecreasePageSubFunction(minionFrame,ListOfCardListsMinions);
        }
        else if (spellFrame.activeInHierarchy == true)
        {
            DecreasePageSubFunction(spellFrame,ListOfCardListsSpells);
        }
    }

    public void SwitchActiveFrame(GameObject Frame)
    {
        if(Frame == minionFrame)
        {
            ActivateMinionFrame();
        }
        else if (Frame == spellFrame)
        {
            ActivateSpellFrame();
        }
    }

    public void SwitchCostTabMinions(ListOfCardLists ListOfCardLists, int LastSet)
    {
        //public function that all of the cost tab buttons will call to when clicked
        //switches the list of lists being used

        ListOfCardListsMinions = ListOfCardLists;
        lastSetMinions = LastSet;
        ListOfCardListsMinions.counter = 0;
        ListOfCardListsMinions.subcounter = 0;
        

        if(ListOfCardListsMinions.listOfCardLists.Count > 1)
        {
            if (ListOfCardListsMinions.listOfCardLists[ListOfCardListsMinions.counter].cardList.Count >=10)
            {
                CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
                ListOfCardListsMinions.subcounter += 10;
            }
            else
            {
                CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
                newIndex = ListOfCardListsMinions.listOfCardLists[ListOfCardListsMinions.counter].cardList.Count;
                ListOfCardListsMinions.counter += 1;
                CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter,newIndex);
                ListOfCardListsMinions.subcounter += 10 - newIndex;
            }
        }
        else
        {
            if (ListOfCardListsMinions.listOfCardLists[ListOfCardListsMinions.counter].cardList.Count >=10)
            {
                CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
                ListOfCardListsMinions.subcounter += 10;
            }
            else
            {
                CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
                newIndex = ListOfCardListsMinions.listOfCardLists[ListOfCardListsMinions.counter].cardList.Count;
                CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter,newIndex, 1);
            }
        }

    }

    public void SwitchCostTabSpells(ListOfCardLists ListOfCardLists, int LastSet)
    {
        //public function that all of the cost tab buttons will call to when clicked
        //switches the list of lists being used

        ListOfCardListsSpells = ListOfCardLists;
        lastSetSpells = LastSet;
        ListOfCardListsSpells.counter = 0;
        ListOfCardListsSpells.subcounter = 0;
        if(ListOfCardListsSpells.listOfCardLists.Count > 1)
        {
            if (ListOfCardListsSpells.listOfCardLists[ListOfCardListsSpells.counter].cardList.Count >=10)
            {
                CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter);
                ListOfCardListsSpells.subcounter += 10;
            }
            else
            {
                CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter);
                newIndex = ListOfCardListsSpells.listOfCardLists[ListOfCardListsSpells.counter].cardList.Count;
                ListOfCardListsSpells.counter += 1;
                CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter, newIndex);
                ListOfCardListsSpells.subcounter += 10 - newIndex;
            }
        }
        else
        {
            if (ListOfCardListsSpells.listOfCardLists[ListOfCardListsSpells.counter].cardList.Count >=10)
            {
                CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter);
                ListOfCardListsSpells.subcounter += 10;
            }
            else
            {
                CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter);
                newIndex = ListOfCardListsSpells.listOfCardLists[ListOfCardListsSpells.counter].cardList.Count;
                CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter, newIndex, 1);
            }
        }
        
        
        

        
    }
    

    //turn on minion frame turn off spell frame
    private void ActivateMinionFrame()
    {
        minionFrame.SetActive(true);
        spellFrame.SetActive(false);
        ListOfCardListsMinions.counter = 0;
        
        if(ListOfCardListsMinions.listOfCardLists[ListOfCardListsMinions.counter].cardList.Count>=10)
        {
            ListOfCardListsMinions.subcounter = 0;
            CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
            ListOfCardListsMinions.subcounter += 10;  
        }
        else
        {
            ListOfCardListsMinions.subcounter = 0;
            CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter);
            newIndex = 10 - ListOfCardListsMinions.listOfCardLists[ListOfCardListsMinions.counter].cardList.Count;
            ListOfCardListsMinions.counter +=1;  
            CallPopulator(minionFrame,ListOfCardListsMinions,ListOfCardListsMinions.counter,ListOfCardListsMinions.subcounter, newIndex);
            ListOfCardListsMinions.subcounter = 10 - newIndex;
        }

    }
    //turn on spell frame turn off minion frame
    private void ActivateSpellFrame()
    {

        minionFrame.SetActive(false);
        spellFrame.SetActive(true);
        ListOfCardListsSpells.counter = 0;  
        
        if(ListOfCardListsSpells.listOfCardLists[ListOfCardListsSpells.counter].cardList.Count>=10)
        {
            ListOfCardListsSpells.subcounter = 0;
            CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter);
            ListOfCardListsSpells.subcounter += 10;  
        }
        else
        {
            ListOfCardListsSpells.subcounter = 0;
            CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter);
            newIndex = ListOfCardListsSpells.listOfCardLists[ListOfCardListsSpells.counter].cardList.Count;
            ListOfCardListsSpells.counter +=1;  
            CallPopulator(spellFrame,ListOfCardListsSpells,ListOfCardListsSpells.counter,ListOfCardListsSpells.subcounter, newIndex);
            ListOfCardListsSpells.subcounter = 10 - newIndex;
        }
        
    }

    private void CallPopulator(GameObject Frame, ListOfCardLists ListOfCardLists, int Counter, int Subcounter, int NewIndex = 0, int Terminator = 0)
    {
    	Frame.GetComponent<CardPopulator>().PopulateCards(ListOfCardLists.listOfCardLists[Counter],Subcounter, NewIndex, Terminator);
    }

    private void IncreasePageSubFunction(GameObject Frame, ListOfCardLists ListOfCardLists,int LastSet)
    {
    		if (ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-ListOfCardLists.subcounter>10)
            { 
                
                // we print 10 cards from the current set at the current sub counter, then increase the sub counter by 10
                CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                ListOfCardLists.subcounter += 10;
            }
            else if (ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-ListOfCardLists.subcounter==10)
            {
                
                if (ListOfCardLists.counter < LastSet)
                {
                    // if there are exactly 10 cards left then perfect, we fill up the rows and then increase the count by 1
                    // and reset the sub count to 0
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    ListOfCardLists.counter += 1;
                    ListOfCardLists.subcounter = 0;
                }
                else if(ListOfCardLists.counter == LastSet)
                {
                    // version of above but if we are on the last set
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                }
            }
            else if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-ListOfCardLists.subcounter<10 && ListOfCardLists.counter < LastSet)
            {
                if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-ListOfCardLists.subcounter == 0)
                {
                    ListOfCardLists.counter += 1;
                    ListOfCardLists.subcounter = 0;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    
                    if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count<10)
                    {
                        newIndex = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count;
                        ListOfCardLists.subcounter += newIndex;
                        CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter, newIndex, 1);

                    }
                    else
                    {
                        ListOfCardLists.subcounter += 10;
                    }
                }

                else
                {
                    //if there are less than 10 cards left in the set (and its not the last set), then we print them all, 
                    //set up a new variable called newIndex to store the position that the last card was printed at. 
                    //Then we will increase the count by 1, reset the subcount
                    // back down to 0, then print the remaining cards starting at that newIndex position (for the physical position of the cards,
                    //not the actual location in the list). Finally we will increase the subcount by the number of cards printed the second time
                    // we do this by taking the number of cards printable, 10, and subtracting off the newindex.
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    newIndex = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-(ListOfCardLists.subcounter);
                    ListOfCardLists.counter += 1;
                    ListOfCardLists.subcounter = 0;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter, newIndex);
                    ListOfCardLists.subcounter += 10 - newIndex; 
                }
                
            }
            else if (ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-ListOfCardLists.subcounter<10 && ListOfCardLists.counter == LastSet)
            {
                if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-ListOfCardLists.subcounter == 0)
                {

                }
                else
                {
                    // in this scenario we are currently working on the last set, and are near the end of it (hence less than 10 cards left to print)
                    // obviously since this is the last set we do not want to increase the counter and move on to the next set (which doesnt exist)
                    // therefore we want to print all of the cards that we can, then disable the rest of the card spots.
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    newIndex = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count-(ListOfCardLists.subcounter);
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter, newIndex, 1);
                    // the last arguement of 1, tells CallPopulator to turn off the remain slots, starting from newIndex
                }
            }   
    }

    private void DecreasePageSubFunction(GameObject Frame, ListOfCardLists ListOfCardLists)
    {
        if(ListOfCardLists.subcounter > 10)
        {
            
            if (ListOfCardLists.subcounter >=20 )
            {
                ListOfCardLists.subcounter -=20;
                CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                ListOfCardLists.subcounter +=10;
            }
            else if (ListOfCardLists.subcounter < 20)
            {
                ListOfCardLists.subcounter -=10;
                newIndex = 10 - ListOfCardLists.subcounter;
                ListOfCardLists.subcounter = 0;
                CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter, newIndex);
                ListOfCardLists.counter -=1;
                ListOfCardLists.subcounter = ListOfCardLists.subcounter = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count - newIndex;
                CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                ListOfCardLists.counter +=1;
                ListOfCardLists.subcounter = 10 - newIndex;
            }
        }
        else if(ListOfCardLists.subcounter == 10)
        {   
                
            if (ListOfCardLists.counter != 0)
            {
                if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count>=10)
                {
                    //we subtract 10 from the subcounter, print those cards, then we decrease the set and set the new sub counter to be at the
                    //very end of the current set
                    ListOfCardLists.counter -=1;
                    ListOfCardLists.subcounter -=10;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    ListOfCardLists.subcounter +=10;
                }
                else
                {
                    ListOfCardLists.counter -=1;
                    ListOfCardLists.subcounter -=ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    newIndex = 10 - ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter+1,0,newIndex);

                }
            }
            else if(ListOfCardLists.counter == 0)
            {
                //if we are in the first set then we will just not incriment the set value down at all.
                ListOfCardLists.subcounter -=10;
                CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                ListOfCardLists.subcounter +=10;

            }
        }
        else if(ListOfCardLists.subcounter < 10)
        {
            
            // we subtract all that we can from the current set, note how many that was in newIndex, print those cards starting at the
            //index specified by newIndex. We then move down a set and subtract the complement of newIndex from that sets subcounter, then 
            // we start printing cards like normal
            if(ListOfCardLists.counter > 1)
            {
                ListOfCardLists.counter -=1;
                newIndex = 10 - ListOfCardLists.subcounter;//how many cards were printed in the current frame from the previous set
                ListOfCardLists.subcounter = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count - newIndex;

                if(ListOfCardLists.subcounter < 10)
                // this tells us that the set we are decending to has less cards than 10 + however were overflow printed to the on screen frame
                // this means that we are going to have to reach back one more step and print another card.
                {   
                    newIndex = 10 - ListOfCardLists.subcounter;
                    ListOfCardLists.subcounter = 0;

                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter, newIndex);
                    ListOfCardLists.counter -=1;
                    ListOfCardLists.subcounter = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count - newIndex;

                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    ListOfCardLists.counter +=1;
                    ListOfCardLists.subcounter = 10 - newIndex;
                }
                else
                {
                    ListOfCardLists.subcounter -=10;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    ListOfCardLists.subcounter +=10;
                    
                }
            }

            //(((((((((((((((((CURRENTLY WORKONG HERE)))))))))))))))))
            else if (ListOfCardLists.counter == 1)
            {
                ListOfCardLists.counter -=1;

                if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count < 10)
                {
                     newIndex = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count;// how many left over cards
                     ListOfCardLists.subcounter = 0;
                     CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                     ListOfCardLists.counter +=1;
                     CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter, newIndex);
                     ListOfCardLists.subcounter = 10 - newIndex;
                }
                else if(ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count == 10)
                {
                    ListOfCardLists.subcounter = 0;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    ListOfCardLists.subcounter +=10;
                }
                else//ie more than 10 cards in the set
                {                    
                    newIndex = 10 - ListOfCardLists.subcounter;// how many cards got printed before we steped the set down by 1
                    ListOfCardLists.subcounter = ListOfCardLists.listOfCardLists[ListOfCardLists.counter].cardList.Count - newIndex;
                    ListOfCardLists.subcounter -=10;
                    CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
                    ListOfCardLists.subcounter +=10;
                }
            }
            else if (ListOfCardLists.counter == 0)
            {
                CallPopulator(Frame,ListOfCardLists,ListOfCardLists.counter,ListOfCardLists.subcounter);
            }   
        }
    }
}
