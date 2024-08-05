using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Money money = null;
    [SerializeField] private SetItemInfo set_item_info = null;
    [SerializeField] private Transform food_slots = null;
    [SerializeField] private Transform weapon_slots = null;
    [SerializeField] private Transform item_info_popup = null;

    private Button button = null;

    private List<Slot> slot_list = new List<Slot>();

    private int food_slots_count = 0;
    private int weapon_slots_count = 0;
    private int item_price = 0;

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
            else
            {
                slot.GetComponent<Button>().interactable = false;
            }

            slot_list.Add(slot);
        }

        for (int i = 0; i < weapon_slots_count; i++)
        {
            var slot = weapon_slots.GetChild(i).gameObject.GetComponent<Slot>();

            slot.GetComponent<Button>().interactable = false;

            slot_list.Add(slot);
        }
    }

    public void ItemInfoPopup(Slot slot) // Item info popup 정보
    {
        item_info_popup.GetChild(0).GetComponent<TextMeshProUGUI>().text = slot.item_info.name;
        item_info_popup.GetChild(1).GetComponent<Image>().sprite = slot.item_info.image;
        item_info_popup.GetChild(2).GetComponent<TextMeshProUGUI>().text = $"{slot.item_info.price}원";
        item_info_popup.GetChild(3).GetComponent<TextMeshProUGUI>().text = slot.item_info.explanation;

        item_price = slot.item_info.price;
    }

    public void ItemBuy()
    {
        if (money.GetMoney() >= item_price)
        {
            int result = money.GetMoney() - item_price;

            money.SetMoney(result);

            Debug.Log("구매 완료");
        }
        else
        {
            Debug.Log("잔액 부족");
        }
    }
}