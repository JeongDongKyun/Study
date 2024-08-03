using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Animator item_info_popup_ar = null;
    private GameObject item_info_popup_obj = null;

    private void Awake()
    {
        item_info_popup_obj = GameObject.Find("Item info popup");
        item_info_popup_ar = item_info_popup_obj.GetComponent<Animator>();
    }

    public void OnPopupAM()
    {
        if (!item_info_popup_ar.enabled)
        {
            item_info_popup_ar.enabled = true;
        }

        item_info_popup_ar.Play("OnItemInfoPopupAM", 0, 0);
    }

    public void OffPopupAM()
    {
        item_info_popup_ar.Play("OffItemInfoPopupAM", 0, 0);
    }
}