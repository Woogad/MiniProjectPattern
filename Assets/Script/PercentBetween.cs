using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PercentBetween : IPercent_Strategy
{
    public void CalPercent(float a, float b, TMP_Text text)
    {
        float result = ((a - b) / a) * 100;

        text.text = $"{result}%";
    }
}
