using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontroler
{
    public static int skor = 0;
    int temp = 0;
    private void Update()
    {
        if (temp != skor)
        {
            Debug.Log("Skor: " + skor);
        }
        temp = skor;
    }
}
