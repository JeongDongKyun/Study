using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Inventory> inventory_list = new List<Inventory>();

    [SerializeField] private Transform slot = null;

    [SerializeField] private int slot_count = 0;

    private void Start()
    {
        slot_count = slot.childCount;

        for (int i = 0; i < slot_count; i++)
        {
            var slot = this.slot.GetChild(i).GetComponent<Slot>();

            if (slot != null)
            {
                Debug.Log(this.gameObject.name + "비어 있음!");

                // inventory_list.Add(slot);
            }
        }
    }
}