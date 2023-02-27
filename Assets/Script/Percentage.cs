using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Percentage : IPercent_Strategy
{

    public void CalPercent(float a, float b, TMP_Text text)
    {
        float result = b * (a / 100);
        text.text = $"{result}";
    }
}
