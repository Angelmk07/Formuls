using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    [SerializeField] private Button Button;
    [SerializeField] private TMP_InputField input1;
    [SerializeField] private TMP_InputField input2;
    [SerializeField] private So_FormulView So_Formul;

    
    [SerializeField] private TextMeshProUGUI Formula;
    [SerializeField] private TextMeshProUGUI Param1;
    [SerializeField] private TextMeshProUGUI Param2;

    [SerializeField] private string ParamText1;
    [SerializeField] private string ParamText2;

    [SerializeField] private TextMeshProUGUI Answer;
    private void Start()
    {
        Formula.text = So_Formul.Formula;
        Button.onClick.AddListener(Ansver);
    }
    private void Update()
    {
        if (Param1 != null)
        {
            Param1.text = ParamText1;
        }
        if(Param2 != null ) 
        {
            Param2.text = ParamText2;
        }
 
        if (input1!=null&&input1.text == ""|| input2 != null && input2.text == "")
        {
            Button.interactable = false;
        }
        else
        {
            Button.interactable = true;
        }
       
    }
    void Ansver()
    {
        switch (So_Formul.Id) 
        {
            case 0:
                Answer.text = Calculation.formula1(float.Parse(input1.text)).ToString();
                break;
            case 1:
                Answer.text = Calculation.formula2(float.Parse(input1.text), float.Parse(input2.text)).ToString();
                break;
            case 2:
                Answer.text = Calculation.formula3(float.Parse(input1.text), float.Parse(input2.text)).ToString();
                break;
            case 3:
                Answer.text = Calculation.formula4(float.Parse(input1.text), float.Parse(input2.text)).ToString();
                break;
            case 4:
                Answer.text = Calculation.formula5(int.Parse(input1.text)).ToString();
                break;

        }

    }



}
