using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private GameObject on_off_obj = null;
    [SerializeField] private GameObject item_info_popup_obj = null;
    private bool on_off_tr = false;

    public void OnMouseDown()
    {
        item_info_popup_obj.transform.localPosition = new Vector2(300, -150);

        on_off_tr = !on_off_tr;

        on_off_obj.SetActive(on_off_tr);
    }
}