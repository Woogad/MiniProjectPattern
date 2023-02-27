using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PercentCalculator : MonoBehaviour
{
    [SerializeField] private Button Cal_bn;
    [SerializeField] private TMP_InputField a_input;
    [SerializeField] private TMP_InputField b_input;
    [SerializeField] private TMP_Dropdown CalMethod_dropdown;
    [SerializeField] private TMP_Text Result_text;
    [SerializeField] private TMP_Text Prefix_text;
    [SerializeField] private TMP_Text Mid_text;

    private TMP_Dropdown.OptionData Percentage = new TMP_Dropdown.OptionData("เปอร์เซ็นต์ ของ จำนวน");
    private TMP_Dropdown.OptionData FindPercent = new TMP_Dropdown.OptionData("จำนวน ของ เปอร์เซ็นต์");
    private TMP_Dropdown.OptionData PercentChange = new TMP_Dropdown.OptionData("หาเปอร์เซ็นต์ระหว่าง 2 ค่า");

    private Strategy strategy = new Strategy();

    private void Awake()
    {
        CalMethod_dropdown.AddOptions(new List<TMP_Dropdown.OptionData>{
            Percentage,
            FindPercent,
            PercentChange,
        });

        Cal_bn.onClick.AddListener(CalculatorPercent);
    }
    public void CalculatorPercent()
    {
        float a = float.Parse(a_input.text);
        float b = float.Parse(b_input.text);

        switch (CalMethod_dropdown.value)
        {
            case 0:
                strategy.setStrategy(new Percentage());
                break;
            case 1:
                strategy.setStrategy(new FindPercent());
                break;
            case 2:
                strategy.setStrategy(new PercentBetween());
                break;
            default:
                Result_text.text = "No result";
                break;
        }
        strategy.CalPercent(a, b, Result_text);
    }


    private void Update()
    {

        switch (CalMethod_dropdown.value)
        {
            case 0:
                Prefix_text.text = "%";
                Mid_text.text = "ของ";
                break;
            case 1:
                Prefix_text.text = "จำนวน";
                Mid_text.text = "เป็นกี่เปอร์เซ็นต์ของ";
                break;
            case 2:
                Prefix_text.text = "จำนวน";
                Mid_text.text = "ถึง";
                break;
            default:
                Prefix_text.text = "";
                Mid_text.text = "";
                Result_text.text = "No result";
                break;
        }
    }
}
