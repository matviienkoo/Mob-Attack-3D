using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Rename_tag : MonoBehaviour
{
    int pizdabol;

    private void OnCollisionEnter(Collision other){
    if (GetComponent<Collider>().CompareTag("add"))
    {   
        if (pizdabol == 0){
        gameObject.tag = "add_special";
        pizdabol = 1;
        }
    }
    }
}


