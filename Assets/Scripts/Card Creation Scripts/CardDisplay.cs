using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//https://www.youtube.com/watch?v=aPXvoWVabPY
public class CardDisplay : MonoBehaviour
{
	public Card card;

	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;

	public Text manaText;

	public Text damageText;
    public Text fireRateText;
    public Text ammoMaxText;

	public Text structureText;
    public Text armorToughnessText;
    public Text armorText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCard();
    }
    public void UpdateCard()
    {
        if(card.cardType == CardType.Minion)
        {
            Minion _card = (Minion) card;
            nameText.text = _card.name;
            descriptionText.text = _card.description;

            artworkImage.sprite = _card.artwork;

            manaText.text = _card.manaCost.ToString();

            damageText.text = _card.damage.ToString();
            fireRateText.text = _card.fireRate.ToString();
            ammoMaxText.text = _card.ammoMax.ToString();
     
            structureText.text = _card.structure.ToString();
            armorText.text = _card.armor.ToString();
            armorToughnessText.text = _card.armorToughness.ToString();
        }
        else if (card.cardType == CardType.Spell)
        {
            Spell _card = (Spell) card;
            nameText.text = _card.name;
            descriptionText.text = _card.description;

            artworkImage.sprite = _card.artwork;

            manaText.text = _card.manaCost.ToString();
        }
    }

}
