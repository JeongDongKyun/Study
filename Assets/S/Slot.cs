using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image image = null;

    [HideInInspector] public ItemInfo item_info = null;

    public void SlotItem(ItemInfo item)
    {
        item_info = item;

        if (item != null)
        {
            image.enabled = true;

            this.gameObject.name = item.name;
            image.sprite = item.image;
        }
        else
        {
            image.enabled = false;

            this.gameObject.name = "Null";
        }
    }
}