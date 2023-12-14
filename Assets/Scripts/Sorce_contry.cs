using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sorce_contry : MonoBehaviour
{
public Text contry_text;
public TextMeshProUGUI text;
int int_text;

public string textNOTHING;
public string textUK;
public string textUKR;
public string textCND;
public string textRUS;
public string textUSA;
public string textNTH;
public string textITL;
public string textGER;
public string textFRC;
public string textASTR;
public string textSWD;
public string textNRW;
public string textFN;
public string textDNM;
public string textCZ;
public string textSLK;
public string textHUNG;
public string textBULG;
public string textSPN;

void Start (){
    contry_text.text = RegionInfo.CurrentRegion.DisplayName;

    if (contry_text.text == "United Kingdom"){
        text.text = textUK;
        int_text = 1;
    }
    if (contry_text.text == "Russia"){
        text.text = textRUS;
        int_text = 1;
    }
    if (contry_text.text == "Ukraine"){
        text.text = textUKR;
        int_text = 1;
    }
    if (contry_text.text == "Canada"){
        text.text = textCND;
        int_text = 1;
    }
    if (contry_text.text == "United States"){
        text.text = textUSA;
        int_text = 1;
    }
    if (contry_text.text == "Netherlands"){
        text.text = textNTH;
        int_text = 1;
    }
    if (contry_text.text == "Italy"){
        text.text = textITL;
        int_text = 1;
    }
    if (contry_text.text == "Germany"){
        text.text = textGER;
        int_text = 1;
    }
    if (contry_text.text == "France"){
        text.text = textFRC;
        int_text = 1;
    }
    if (contry_text.text == "Austria"){
        text.text = textASTR;
        int_text = 1;
    }
    if (contry_text.text == "Sweden"){
        text.text = textSWD;
        int_text = 1;
    }
    if (contry_text.text == "Norway"){
        text.text = textNRW;
        int_text = 1;
    }
    if (contry_text.text == "Finland"){
        text.text = textFN;
        int_text = 1;
    }
    if (contry_text.text == "Denmark"){
        text.text = textDNM;
        int_text = 1;
    }
    if (contry_text.text == "Czech Republic"){
        text.text = textCZ;
        int_text = 1;
    }
    if (contry_text.text == "Slovakia"){
        text.text = textSLK;
        int_text = 1;
    }
    if (contry_text.text == "Hungary"){
        text.text = textHUNG;
        int_text = 1;
    }
    if (contry_text.text == "Bulgaria"){
        text.text = textBULG;
        int_text = 1;
    }
    if (contry_text.text == "Spain"){
        text.text = textSPN;
        int_text = 1;
    }
}

void Update ()
{
    if (int_text == 0){
        text.text = textNOTHING;
        int_text = 2;
    }
}
}

