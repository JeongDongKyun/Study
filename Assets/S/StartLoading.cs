using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoading : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Loading.NextScene("Game1");
        }
    }
}