using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemUI : MonoBehaviour {

    #region Data
    public Item Item { get; private set; }
    public int Amount { get; private set; }
    #endregion

    #region UI Component
    private Image itemImage;
    private Text amountText;

    private Image ItemImage
    {
        get
        {
            if (itemImage == null)
            {
                itemImage = GetComponent<Image>();
            }
            return itemImage;
        }
    }
    private Text AmountText
    {
        get
        {
            if (amountText == null)
            {
                amountText = GetComponentInChildren<Text>();
            }
            return amountText;
        }
    }
    #endregion

    public void SetItem(Item item, int amount = 1)
    {
        //transform.localScale = animationScale;
        this.Item = item;
        this.Amount = amount;
        // update ui 
        ItemImage.sprite = Resources.Load<Sprite>(item.Sprite);
        if (Item.Capacity > 1)
            AmountText.text = Amount.ToString();
        else
            AmountText.text = "";
    }

    public void AddAmount(int amount = 1)
    {
        //transform.localScale = animationScale;
        this.Amount += amount;
        //update ui 
        if (Item.Capacity > 1)
            AmountText.text = Amount.ToString();
        else
            AmountText.text = "";
    }
}
