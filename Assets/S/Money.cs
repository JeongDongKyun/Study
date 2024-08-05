using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    private TextMeshProUGUI tmp = null;

    private int money = 0;

    private void Awake()
    {
        tmp = this.GetComponent<TextMeshProUGUI>();
    }

    private void Update() // test
    {
        tmp.text = $"{money}��";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            money += 1000;

            Debug.Log("�� ġƮŰ ��� �Ϸ�");
        }
    }

    public void SetMoney(int money)
    {
        this.money = money;
    }

    public int GetMoney()
    {
        return money;
    }
}