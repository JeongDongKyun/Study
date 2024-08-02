using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Animator ar;

    private bool tr = false;

    private void Awake()
    {
        ar = this.GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        ar.Play("321312", 0, 0.0f);
    }
}