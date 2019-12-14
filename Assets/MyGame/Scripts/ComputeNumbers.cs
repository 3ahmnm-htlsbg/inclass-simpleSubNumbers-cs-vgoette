using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField varA;
    public InputField varB;
    public Button btn_reset;
    public Button btn_subNumbers;

    public void SetResult()
    {
        result.text = AddNumbers().ToString();
        //set gui-elements active/inactive
        varA.interactable = false;
        varB.interactable = false;
        btn_subNumbers.interactable = false;
        btn_reset.interactable = true;
    }

    public void Reset ()
    {
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        btn_subNumbers.interactable = true;
        btn_reset.interactable = false;
    }

    private int AddNumbers()
    {
        int tempResult = int.Parse(varA.text) - int.Parse(varB.text);
        return tempResult;
    }

}