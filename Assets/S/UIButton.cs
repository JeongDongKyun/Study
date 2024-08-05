using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
    [SerializeField] private Button shop_button_ui = null;
    [SerializeField] private Button bag_button_ui = null;
    [SerializeField] private GameObject shop_on_off_obj = null;
    [SerializeField] private GameObject bag_on_off_obj = null;
    [SerializeField] private RectTransform shop_content_obj = null;
    [SerializeField] private RectTransform bag_content_obj = null;
    [SerializeField] private Transform item_info_popup_obj = null;

    private bool on_off_tr = false;

    public void ShopButtonUI()
    {
        shop_content_obj.localPosition = new Vector2(0, -950);
        item_info_popup_obj.localPosition = new Vector2(300, -150);

        on_off_tr = !on_off_tr;
        bag_button_ui.interactable = !on_off_tr;

        shop_on_off_obj.SetActive(on_off_tr);
    }

    public void BagButtonUI()
    {
        bag_content_obj.localPosition = new Vector2(1500, 0);

        on_off_tr = !on_off_tr;
        shop_button_ui.interactable = !on_off_tr;

        bag_on_off_obj.SetActive(on_off_tr);
    }
}