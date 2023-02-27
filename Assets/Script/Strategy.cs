using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Strategy
{
    private IPercent_Strategy percent_Strategy;

    public void setStrategy(IPercent_Strategy percent_Strategy)
    {
        this.percent_Strategy = percent_Strategy;
    }

    public void CalPercent(float a, float b, TMP_Text text)
    {
        this.percent_Strategy.CalPercent(a, b, text);
    }

}
