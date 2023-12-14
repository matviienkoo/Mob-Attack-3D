using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinsManager : MonoBehaviour
{
    public GameObject skins_panel;

    public void open (){
        if(skins_panel != null){
        skins_panel.SetActive(true);
        }
    }

    public void closed(){
        if(skins_panel != null){
        skins_panel.SetActive(false);
        }
    }

}


