﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public int ID { get; set; }
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public ItemQuality Quality { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int BuyPrice { get; set; }
    public int SellPrice { get; set; }
    public string Sprite { get; set; }


    public Item()
    {
        this.ID = -1;
    }

    public Item(int id, string name, ItemType type, ItemQuality quality, string des, int capacity, int buyPrice, int sellPrice, string sprite)
    {
        this.ID = id;
        this.Name = name;
        this.Type = type;
        this.Quality = quality;
        this.Description = des;
        this.Capacity = capacity;
        this.BuyPrice = buyPrice;
        this.SellPrice = sellPrice;
        this.Sprite = sprite;
    }


    /// <summary>
    /// 物品类型
    /// </summary>
    public enum ItemType
    {
        Consumable,
        Equipment,
        Weapon,
        Material
    }
    /// <summary>
    /// 品质
    /// </summary>
    public enum ItemQuality
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Artifact
    }

    /// <summary> 
    /// 得到提示面板应该显示什么样的内容
    /// </summary>
    /// <returns></returns>
    //public virtual string GetToolTipText()
    //{
    //    string color = "";
    //    switch (Quality)
    //    {
    //        case ItemQuality.Common:
    //            color = "white";
    //            break;
    //        case ItemQuality.Uncommon:
    //            color = "lime";
    //            break;
    //        case ItemQuality.Rare:
    //            color = "navy";
    //            break;
    //        case ItemQuality.Epic:
    //            color = "magenta";
    //            break;
    //        case ItemQuality.Legendary:
    //            color = "orange";
    //            break;
    //        case ItemQuality.Artifact:
    //            color = "red";
    //            break;
    //    }
    //}
}
