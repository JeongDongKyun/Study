using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInfo
{
    [Header("상점 아이템 정보")]
    public string name = null;
    public Sprite image = null;
    public int price = 0;
    public string explanation = null;
}