using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    private ScrollRect sr = null;

    private void Awake()
    {
        sr = this.GetComponent<ScrollRect>();
    }

    private void Update()
    {
        Vector2 content_pos = sr.content.anchoredPosition;

        Debug.Log(content_pos.y);

        if (content_pos.y <= 0)
        {
            content_pos = Vector2.zero;

            Debug.Log("더이상 못 올라갑니다!");
        }
    }
}