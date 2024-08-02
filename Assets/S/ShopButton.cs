using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private GameObject on_off_obj = null;
    private bool on_off_tr = false;

    public void OnMouseDown()
    {
        on_off_tr = !on_off_tr;

        on_off_obj.SetActive(on_off_tr);
    }
}