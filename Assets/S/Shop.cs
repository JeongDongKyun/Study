using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private SetItemInfo set_item_info = null;
    [SerializeField] private Transform food_slots = null;
    [SerializeField] private Transform weapon_slots = null;

    private Button button = null;

    private List<Slot> slot_list = new List<Slot>();

    private int food_slots_count = 0;
    private int weapon_slots_count = 0;

    private void Awake()
    {
        button = this.GetComponent<Button>();
    }

    private void Start()
    {
        food_slots_count = food_slots.childCount;
        weapon_slots_count = weapon_slots.childCount;

        for (int i = 0; i < food_slots_count; i++)
        {
            var slot = food_slots.GetChild(i).gameObject.GetComponent<Slot>();

            if (i < set_item_info.iteminfo_list.Count)
            {
                slot.SlotItem(set_item_info.iteminfo_list[i]);
            }

            slot_list.Add(slot);
        }

        for (int i = 0; i < weapon_slots_count; i++)
        {
            var slot = weapon_slots.GetChild(i).gameObject.GetComponent<Slot>();

            slot_list.Add(slot);
        }
    }
}