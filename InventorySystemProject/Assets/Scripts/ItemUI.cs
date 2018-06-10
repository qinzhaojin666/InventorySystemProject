﻿using System.Collections;
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


    #region Item 动画
    private float targetScale = 1f;

    private Vector3 animationScale = new Vector3(1.4f, 1.4f, 1.4f);

    private float smoothing = 4;
    #endregion

    void Update()
    {
        if (transform.localScale.x != targetScale)
        {
            //动画
            float scale = Mathf.Lerp(transform.localScale.x, targetScale, smoothing * Time.deltaTime);
            transform.localScale = new Vector3(scale, scale, scale);
            if (Mathf.Abs(transform.localScale.x - targetScale) < .02f)
            {
                transform.localScale = new Vector3(targetScale, targetScale, targetScale);
            }
        }
    }

    public void SetItem(Item item, int amount = 1)
    {
        transform.localScale = animationScale;
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
    #region PicedItem
    /// <summary>
    /// pickedItem的显示和隐藏
    /// </summary>
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
    /// <summary>
    /// 设置PickedItem的位置
    /// </summary>
    /// <param name="position"></param>
    public void SetLocalPosition(Vector3 position)
    {
        transform.localPosition = position;
    }
    #endregion
    /// <summary>
    /// 设置Amount更新UI在物品捡起来的时候
    /// </summary>
    /// <param name="amount"></param>
    /// 
    public void SetAmount(int amount)
    {
        transform.localScale = animationScale;
        this.Amount = amount;
        //update ui 
        if (Item.Capacity > 1)
            AmountText.text = Amount.ToString();
        else
            AmountText.text = "";
    }
    /// <summary>
    /// 当捡起的物品放回背包的时候更新UI
    /// </summary>
    /// <param name="amount"></param>
    public void ReduceAmount(int amount = 1)
    {
        transform.localScale = animationScale;
        this.Amount -= amount;
        //update ui 
        if (Item.Capacity > 1)
            AmountText.text = Amount.ToString();
        else
            AmountText.text = "";
    }
    /// <summary>
    /// 交换显示
    /// </summary>
    /// <param name="itemUI"></param>
    public void Exchange(ItemUI itemUI)
    {
        Item itemTemp = itemUI.Item;
        int amountTemp = itemUI.Amount;
        itemUI.SetItem(this.Item, this.Amount);
        this.SetItem(itemTemp, amountTemp);
    }
}
