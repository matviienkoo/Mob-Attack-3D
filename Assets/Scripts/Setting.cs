using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public GameObject setting_panel;

    public GameObject tap_menu;
    public GameObject level;
    public GameObject money;

    public void open (){
        if(setting_panel != null){
        setting_panel.SetActive(true);
        }

        if(tap_menu != null){
        tap_menu.SetActive(false);
        }
        if(level != null){
        level.SetActive(false);
        }
        if(money != null){
        money.SetActive(false);
        }
    }

    public void closed(){
        if(setting_panel != null){
        setting_panel.SetActive(false);
        }

        if(tap_menu != null){
        tap_menu.SetActive(true);
        }
        if(level != null){
        level.SetActive(true);
        }
        if(money != null){
        money.SetActive(true);
        }
    }

}


