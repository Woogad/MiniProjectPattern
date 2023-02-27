using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FindPercent : IPercent_Strategy
{
    public void CalPercent(float a, float b, TMP_Text text)
    {
        float result = a / b;
        text.text = $"{result * 100}%";
    }
}
