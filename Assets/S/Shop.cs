using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Transform parent_slot = null;

    private int slot_count = 0;

    private void Start()
    {
        slot_count = parent_slot.childCount;

        for (int i = 0; i < slot_count; i++)
        {
            // 
        }
    }
}