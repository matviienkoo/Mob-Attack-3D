using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VipManager : MonoBehaviour
{
    public GameObject vip_panel;

    public void open (){
        if(vip_panel != null){
        vip_panel.SetActive(true);
        }
    }

    public void closed(){
        if(vip_panel != null){
        vip_panel.SetActive(false);
        }
    }

}


